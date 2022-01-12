using LagartoStoreApp.BLL;
using System;
using System.Collections.Generic;
using System.Data;

namespace LagartoStoreApp.DAL
{
    public sealed class ProductoDAL : ICrud<Producto>
    {
        public void Create(Producto producto)
        {
            if (producto is null) throw new ArgumentNullException(nameof(producto));

            ConexionBD.SetData("INSERT INTO PRODUCTOS (NOMBRE, PRECIO, ID_CATEGORIA) " +
                               "VALUES ('" + producto.Nombre + "', " + producto.Precio + ", " + producto.Categoria.Id + ")", 
                               out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }

        public void Delete(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            ConexionBD.SetData("DELETE FROM PRODUCTOS WHERE ID_PRODUCTO = " + id, out int rows);

            if (rows == 0) throw new Exception("No se eliminó ningún registro.");
        }

        public List<Producto> GetAll()
        {
            List<DBParametro> parametros = new List<DBParametro>();
            parametros.Add(new DBParametro("P_ID_PRODUCTO", 0));
            DataTable dataTable = ConexionBD.GetData("GET_PRODUCTOS", parametros).Tables[0];

            List<Producto> productos = new List<Producto>();
            foreach (DataRow row in dataTable.Rows)
            {
                productos.Add(new Producto(Convert.ToInt32(row["ID_PRODUCTO"]), 
                                           row["NOMBRE"].ToString(),
                                           Convert.ToDecimal(row["PRECIO"]), 
                                           new Categoria(Convert.ToInt32(row["ID_CATEGORIA"]),
                                                         row["NOMBRE_CATEGORIA"].ToString())));
            }

            return productos;
        }

        public Producto GetByID(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            List<DBParametro> parametros = new List<DBParametro>();
            parametros.Add(new DBParametro("P_ID_PRODUCTO", id));
            DataTable dataTable = ConexionBD.GetData("GET_PRODUCTOS", parametros).Tables[0];

            if (dataTable.Rows.Count == 0) throw new Exception("No se encontró el producto de ID: " + id + ".");

            return new Producto(Convert.ToInt32(dataTable.Rows[0]["ID_PRODUCTO"]),
                                dataTable.Rows[0]["NOMBRE"].ToString(),
                                Convert.ToDecimal(dataTable.Rows[0]["PRECIO"]),
                                new Categoria(Convert.ToInt32(dataTable.Rows[0]["ID_CATEGORIA"]),
                                              dataTable.Rows[0]["NOMBRE_CATEGORIA"].ToString()));
        }

        public void Update(Producto producto)
        {
            ConexionBD.SetData("UPDATE PRODUCTOS SET NOMBRE = '" + producto.Nombre + "', " +
                                                    "PRECIO = " + producto.Precio + ", " +
                                                    "ID_CATEGORIA = " + producto.Categoria.Id +
                                             " WHERE ID_PRODUCTO = " + producto.Id, out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }
    }
}
