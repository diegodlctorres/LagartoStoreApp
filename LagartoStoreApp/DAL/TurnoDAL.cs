using LagartoStoreApp.BLL;
using System;
using System.Collections.Generic;
using System.Data;

namespace LagartoStoreApp.DAL
{
    public sealed class TurnoDAL : ICrud<Turno>
    {
        public void Create(Turno turno)
        {
            if (turno is null) throw new ArgumentNullException(nameof(turno));

            ConexionBD.SetData("INSERT INTO CATEGORIAS (NOMBRE, HORA_INICIO, HORA_FIN) " +
                "VALUES ('" + turno.Nombre + "', " +
                        "'" + string.Format("{0:HH:mm:ss}", turno.HoraInicio) + "', " +
                        "'" + string.Format("{0:HH:mm:ss}", turno.HoraFin) + "')", out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }

        public void Delete(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            ConexionBD.SetData("DELETE FROM TURNOS WHERE ID_TURNO = " + id, out int rows);

            if (rows == 0) throw new Exception("No se eliminó ningún registro.");
        }

        public List<Turno> GetAll()
        {
            DataTable dataTable = ConexionBD.GetData("SELECT * FROM TURNOS").Tables[0];

            List<Turno> turnos = new List<Turno>();
            foreach (DataRow row in dataTable.Rows)
            {
                turnos.Add(new Turno(Convert.ToInt32(row["ID_TURNO"]),
                                     row["NOMBRE"].ToString(),
                                     DateTime.Today.Add(TimeSpan.Parse(row["HORA_INICIO"].ToString())),
                                     DateTime.Today.Add(TimeSpan.Parse(row["HORA_FIN"].ToString()))));
            }

            return turnos;
        }

        public Turno GetByID(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            DataTable dataTable = ConexionBD.GetData("SELECT * FROM TURNOS WHERE ID_TURNO = " + id).Tables[0];

            if (dataTable.Rows.Count == 0) throw new Exception("No se encontró la categoría de ID: " + id + ".");

            return new Turno(Convert.ToInt32(dataTable.Rows[0]["ID_TURNO"]),
                             dataTable.Rows[0]["NOMBRE"].ToString(),
                             DateTime.Today.Add(TimeSpan.Parse(dataTable.Rows[0]["HORA_INICIO"].ToString())),
                             DateTime.Today.Add(TimeSpan.Parse(dataTable.Rows[0]["HORA_FIN"].ToString())));
        }

        public void Update(Turno turno)
        {
            ConexionBD.SetData("UPDATE TURNOS SET NOMBRE = '" + turno.Nombre + "', " +
                                                 "HORA_INICIO = '" + string.Format("{0:HH:mm:ss}", turno.HoraInicio) + "', " +
                                                 "HORA_FIN = '" + string.Format("{0:HH:mm:ss}", turno.HoraFin) + "' " +
                                           "WHERE ID_CATEGORIA = " + turno.Id, out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }
    }
}
