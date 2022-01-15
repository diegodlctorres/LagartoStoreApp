using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer
{
    public sealed class ColaboradorDAL : ICrud<Colaborador>
    {
        public void Create(Colaborador colaborador)
        {
            if (colaborador is null) throw new ArgumentNullException(nameof(colaborador));

            AppEngine.usuarioDAL.GetByID(colaborador.Id);

            ConexionBD.SetData("INSER INTO COLABORADORES (ID_USUARIO, ID_CARGO, ID_TURNO) " +
                               "VALUES (" + colaborador.Id + ", " + colaborador.Cargo.Id + ", " + colaborador.Turno.Id + ")",
                               out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }

        public void Delete(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            ConexionBD.SetData("DELETE FROM COLABORADORES WHERE ID_USUARIO = " + id, out int rows);

            if (rows == 0) throw new Exception("No se eliminó ningún registro.");
        }

        public List<Colaborador> GetAll()
        {
            List<DBParametro> parametros = new List<DBParametro>();
            parametros.Add(new DBParametro("P_ID_USUARIO", 0));
            DataTable dataTable = ConexionBD.GetData("GET_COLABORADORES", parametros).Tables[0];

            List<Colaborador> colaboradores = new List<Colaborador>();
            foreach (DataRow row in dataTable.Rows)
            {
                colaboradores.Add(new Colaborador(Convert.ToInt32(row["ID_USUARIO"]),
                                                  row["NOMBRE"].ToString(),
                                                  Convert.ToInt32(row["TELEFONO"]),
                                                  Convert.ToChar(row["SEXO"]),
                                                  row["CORREO"].ToString(),
                                                  Convert.ToInt32(row["DNI"]),
                                                  row["APELLIDO"].ToString(),
                                                  new Cargo(Convert.ToInt32(dataTable.Rows[0]["ID_CARGO"]),
                                                            dataTable.Rows[0]["NOMBRE_CARGO"].ToString(),
                                                            Convert.ToDecimal(dataTable.Rows[0]["SALARIO"])),
                                                  new Turno(Convert.ToInt32(dataTable.Rows[0]["ID_TURNO"]),
                                                            dataTable.Rows[0]["NOMBRE_TURNO"].ToString(),
                                                            DateTime.Today.Add(TimeSpan.Parse(dataTable.Rows[0]["HORA_INICIO"].ToString())),
                                                            DateTime.Today.Add(TimeSpan.Parse(dataTable.Rows[0]["HORA_FIN"].ToString()))),
                                                  Convert.ToDateTime(row["FECHA_INGRESO"]),
                                                  !string.IsNullOrEmpty(row["FECHA_CESE"].ToString()) ?
                                                       Convert.ToDateTime(row["FECHA_CESE"].ToString()) : new DateTime(),
                                                  Convert.ToInt32(row["CODIGO_COLABORADOR"])));
            }

            return colaboradores;
        }

        public Colaborador GetByID(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            List<DBParametro> parametros = new List<DBParametro>();
            parametros.Add(new DBParametro("P_ID_USUARIO", id));
            DataTable dataTable = ConexionBD.GetData("GET_COLABORADORES", parametros).Tables[0];

            if (dataTable.Rows.Count == 0) throw new Exception("No se encontró al colaborador de ID: " + id + ".");

            return new Colaborador(Convert.ToInt32(dataTable.Rows[0]["ID_USUARIO"]),
                                   dataTable.Rows[0]["NOMBRE"].ToString(),
                                   Convert.ToInt32(dataTable.Rows[0]["TELEFONO"]),
                                   Convert.ToChar(dataTable.Rows[0]["SEXO"]),
                                   dataTable.Rows[0]["CORREO"].ToString(),
                                   Convert.ToInt32(dataTable.Rows[0]["DNI"]),
                                   dataTable.Rows[0]["APELLIDO"].ToString(),
                                   new Cargo(Convert.ToInt32(dataTable.Rows[0]["ID_CARGO"]),
                                             dataTable.Rows[0]["NOMBRE_CARGO"].ToString(),
                                             Convert.ToDecimal(dataTable.Rows[0]["SALARIO"])),
                                   new Turno(Convert.ToInt32(dataTable.Rows[0]["ID_TURNO"]),
                                             dataTable.Rows[0]["NOMBRE_TURNO"].ToString(),
                                             DateTime.Today.Add(TimeSpan.Parse(dataTable.Rows[0]["HORA_INICIO"].ToString())),
                                             DateTime.Today.Add(TimeSpan.Parse(dataTable.Rows[0]["HORA_FIN"].ToString()))),
                                   Convert.ToDateTime(dataTable.Rows[0]["FECHA_INGRESO"]),
                                   !string.IsNullOrEmpty(dataTable.Rows[0]["FECHA_CESE"].ToString()) ?
                                        Convert.ToDateTime(dataTable.Rows[0]["FECHA_CESE"].ToString()) : new DateTime(),
                                   Convert.ToInt32(dataTable.Rows[0]["CODIGO_COLABORADOR"]));
        }

        public void Update(Colaborador colaborador)
        {
            AppEngine.usuarioDAL.GetByID(colaborador.Id);

            ConexionBD.SetData("UPDATE COLABORADORES SET ID_CARGO = " + colaborador.Cargo.Id + ", " +
                                                        "ID_TURNO = " + colaborador.Turno.Id+ " " +
                                                 " WHERE ID_USUARIO = " + colaborador.Id, out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }
    }
}