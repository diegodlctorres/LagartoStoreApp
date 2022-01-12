using LagartoStoreApp.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagartoStoreApp.DAL
{
    public sealed class CompraDAL : ICrud<Compra>
    {
        public void Create(Compra compra)
        {
            if (compra is null) throw new ArgumentNullException(nameof(compra));

            ConexionBD.SetData("INSERT INTO COMPRAS (ID_COLABORADOR, ID_CLIENTE) " +
                   "VALUES (" + compra.Colaborador.Id + ", " + compra.Cliente.Id + ")",
                   out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }

        public void Delete(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            ConexionBD.SetData("DELETE FROM COMPRAS WHERE ID_COMPRA = " + id, out int rows);

            if (rows == 0) throw new Exception("No se eliminó ningún registro.");
        }

        public List<Compra> GetAll()
        {
            DataTable dataTable = ConexionBD.GetData("SELECT * FROM COMPRAS").Tables[0];

            List<Compra> compras = new List<Compra>();
            foreach (DataRow row in dataTable.Rows)
            {
                //compras.Add(new Compra(Convert.ToInt32(row["ID_COMPRA"]),
                //                       Convert.ToDateTime(row["FECHA"]),
                //              //new Colaborador( 0, "",0,0,"",0,"",new Cargo(,
                //                       AppEngine.clienteDAL.GetByID(Convert.ToInt32(row["ID_CLIENTE"]))));
            }

            return compras;
        }

        public Compra GetByID(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            DataTable dataTable = ConexionBD.GetData("SELECT * FROM COMPRAS WHERE ID_COMPRA = " + id).Tables[0];

            if (dataTable.Rows.Count == 0) throw new Exception("No se encontró la compra de ID: " + id + ".");

            //return new Compra(Convert.ToInt32(dataTable.Rows[0]["ID_COMPRA"]),
            //                  Convert.ToDateTime(dataTable.Rows[0]["FECHA"]),
            //                  //new Colaborador( 0, "",0,0,"",0,"",new Cargo(,
            //                  AppEngine.clienteDAL.GetByID(Convert.ToInt32(dataTable.Rows[0]["ID_CLIENTE"])));
            return null;
        }

        public void Update(Compra compra)
        {
            throw new NotImplementedException();
        }
    }
}
