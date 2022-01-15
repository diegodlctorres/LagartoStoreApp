using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer
{
    public sealed class CategoriaDAL : ICrud<Categoria>
    {
        public void Create(Categoria categoria)
        {
            if (categoria is null) throw new ArgumentNullException(nameof(categoria));

            ConexionBD.SetData("INSERT INTO CATEGORIAS (NOMBRE) VALUES ('" + categoria.Nombre + "')", out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }

        public void Delete(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            ConexionBD.SetData("DELETE FROM CATEGORIAS WHERE ID_CATEGORIA = " + id, out int rows);

            if (rows == 0) throw new Exception("No se eliminó ningún registro.");
        }

        public List<Categoria> GetAll()
        {
            DataTable dataTable = ConexionBD.GetData("SELECT * FROM CATEGORIAS").Tables[0];

            List<Categoria> categorias = new List<Categoria>();
            foreach (DataRow row in dataTable.Rows)
            {
                categorias.Add(new Categoria(Convert.ToInt32(row["ID_CATEGORIA"]), 
                                             row["NOMBRE"].ToString()));
            }

            return categorias;
        }

        public Categoria GetByID(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            DataTable dataTable = ConexionBD.GetData("SELECT * FROM CATEGORIAS WHERE ID_CATEGORIA = " + id).Tables[0];

            if (dataTable.Rows.Count == 0) throw new Exception("No se encontró la categoría de ID: " + id + ".");

            return new Categoria(Convert.ToInt32(dataTable.Rows[0]["ID_CATEGORIA"]),
                                 dataTable.Rows[0]["NOMBRE"].ToString());
        }

        public void Update(Categoria categoria)
        {
            ConexionBD.SetData("UPDATE CATEGORIAS SET NOMBRE = '" + categoria.Nombre + "' " +
                                               "WHERE ID_CATEGORIA = " + categoria.Id, out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }
    }
}
