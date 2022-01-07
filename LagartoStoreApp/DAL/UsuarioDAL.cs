using LagartoStoreApp.BLL;
using System;
using System.Collections.Generic;
using System.Data;

namespace LagartoStoreApp.DAL
{
    public sealed class UsuarioDAL : ICrud<Usuario>
    {
        public void Create(Usuario usuario)
        {
            if (usuario is null) throw new ArgumentNullException(nameof(usuario));

            ConexionBD.SetData("INSERT INTO USUARIOS (NOMBRE, APELLIDO, DNI, CORREO, SEXO, TELEFONO) " +
                               "VALUES ('" + usuario.Nombre + "', '" + usuario.Apellido + "', " + usuario.Dni + ", '" + usuario.Correo + "', '" + usuario.Sexo + "', " + usuario.Telefono + ")",
                               out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }

        public void Delete(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            ConexionBD.SetData("DELETE FROM USUARIOS WHERE USUARIOS.ID_USUARIO = " + id, out int rows);

            if (rows == 0) throw new Exception("No se eliminó ningún registro.");
        }

        public List<Usuario> GetAll()
        {
            DataTable dataTable = ConexionBD.GetData("SELECT * FROM USUARIOS").Tables[0];

            List<Usuario> usuarios = new List<Usuario>();
            foreach (DataRow row in dataTable.Rows)
            {
                usuarios.Add(new Usuario(Convert.ToInt32(row["ID_USUARIO"]),
                                         row["NOMBRE"].ToString(),
                                         row["APELLIDO"].ToString(),
                                         Convert.ToInt32(row["TELEFONO"]),
                                         Convert.ToChar(row["SEXO"]),
                                         row["CORREO"].ToString(),
                                         Convert.ToInt32(row["DNI"])));
            }

            return usuarios;
        }

        public Usuario GetByID(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            DataTable dataTable = ConexionBD.GetData("SELECT * FROM USUARIOS WHERE USUARIOS.ID_USUARIO = " + id).Tables[0];

            if (dataTable.Rows.Count == 0) throw new Exception("No se encontró al usuario de ID: " + id + ".");

            return new Usuario(Convert.ToInt32(dataTable.Rows[0]["ID_USUARIO"]),
                               dataTable.Rows[0]["NOMBRE"].ToString(),
                               dataTable.Rows[0]["APELLIDO"].ToString(),
                               Convert.ToInt32(dataTable.Rows[0]["TELEFONO"]),
                               Convert.ToChar(dataTable.Rows[0]["SEXO"]),
                               dataTable.Rows[0]["CORREO"].ToString(),
                               Convert.ToInt32(dataTable.Rows[0]["DNI"]));
        }

        public void Update(Usuario usuario)
        {
            ConexionBD.SetData("UPDATE USUARIOS SET NOMBRE = '" + usuario.Nombre + "', " +
                                                   "APELLIDO = '" + usuario.Apellido + "', " +
                                                   "DNI = " + usuario.Dni + ", " +
                                                   "CORREO = '" + usuario.Correo + "', " +
                                                   "SEXO = '" + usuario.Sexo + "', " +
                                                   "TELEFONO = " + usuario.Telefono +
                                            " WHERE ID_USUARIO = " + usuario.Id, out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }
    }
}
