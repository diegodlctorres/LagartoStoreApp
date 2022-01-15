using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer
{
    public sealed class ClienteDAL : ICrud<Cliente>
    {
        public void Create(Cliente cliente)
        {
            if (cliente is null) throw new ArgumentNullException(nameof(cliente));

            AppEngine.usuarioDAL.GetByID(cliente.Id);

            ConexionBD.SetData("INSERT INTO CLIENTES (ID_USUARIO, ID_COLABORADOR_REGISTRO) " +
                               "VALUES (" + cliente.Id + ", " + AppEngine.cuenta.Usuario.Id + ")", 
                               out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }

        public void Delete(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            ConexionBD.SetData("DELETE FROM CLIENTES WHERE ID_USUARIO = " + id, out int rows);

            if (rows == 0) throw new Exception("No se eliminó ningún registro.");
        }

        public List<Cliente> GetAll()
        {
            List<DBParametro> parametros = new List<DBParametro>();
            parametros.Add(new DBParametro("P_ID_USUARIO", 0));
            DataTable dataTable = ConexionBD.GetData("GET_CLIENTES", parametros).Tables[0];

            List<Cliente> clientes = new List<Cliente>();
            foreach (DataRow row in dataTable.Rows)
            {
                clientes.Add(new Cliente(Convert.ToInt32(row["ID_USUARIO"]),
                                         row["NOMBRE"].ToString(),
                                         row["APELLIDO"].ToString(),
                                         Convert.ToInt32(row["TELEFONO"]),
                                         Convert.ToChar(row["SEXO"]),
                                         row["CORREO"].ToString(),
                                         Convert.ToInt32(row["DNI"]),
                                         Convert.ToInt32(row["CODIGO_CLIENTE"])));
            }

            return clientes;
        }

        public Cliente GetByID(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            List<DBParametro> parametros = new List<DBParametro>();
            parametros.Add(new DBParametro("P_ID_USUARIO", id));
            DataTable dataTable = ConexionBD.GetData("GET_CLIENTES", parametros).Tables[0];

            if (dataTable.Rows.Count == 0) throw new Exception("No se encontró al cliente de ID: " + id + ".");

            return new Cliente(Convert.ToInt32(dataTable.Rows[0]["ID_USUARIO"]),
                               dataTable.Rows[0]["NOMBRE"].ToString(),
                               dataTable.Rows[0]["APELLIDO"].ToString(),
                               Convert.ToInt32(dataTable.Rows[0]["TELEFONO"]),
                               Convert.ToChar(dataTable.Rows[0]["SEXO"]),
                               dataTable.Rows[0]["CORREO"].ToString(),
                               Convert.ToInt32(dataTable.Rows[0]["DNI"]),
                               Convert.ToInt32(dataTable.Rows[0]["CODIGO_CLIENTE"]));
        }

        public void Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
