using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer
{
    public sealed class CargoDAL : ICrud<Cargo>
    {
        public void Create(Cargo cargo)
        {
            if (cargo is null) throw new ArgumentNullException(nameof(cargo));

            ConexionBD.SetData("INSERT INTO CARGOS (NOMBRE, SALARIO) " +
                "VALUES ('" + cargo.Nombre + "', " + cargo.Salario +" )", out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }

        public void Delete(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            ConexionBD.SetData("DELETE FROM CARGOS WHERE ID_CARGO = " + id, out int rows);

            if (rows == 0) throw new Exception("No se eliminó ningún registro.");
        }

        public List<Cargo> GetAll()
        {
            DataTable dataTable = ConexionBD.GetData("SELECT * FROM CARGOS").Tables[0];

            List<Cargo> cargos = new List<Cargo>();
            foreach (DataRow row in dataTable.Rows)
            {
                cargos.Add(new Cargo(Convert.ToInt32(row["ID_CARGO"]),
                                     row["NOMBRE"].ToString(),
                                     Convert.ToDecimal(row["SALARIO"])));
            }

            return cargos;
        }

        public Cargo GetByID(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            DataTable dataTable = ConexionBD.GetData("SELECT * FROM CARGOS WHERE ID_CARGO = " + id).Tables[0];

            if (dataTable.Rows.Count == 0) throw new Exception("No se encontró el cargo de ID: " + id + ".");

            return new Cargo(Convert.ToInt32(dataTable.Rows[0]["ID_CARGO"]),
                             dataTable.Rows[0]["NOMBRE"].ToString(),
                             Convert.ToDecimal(dataTable.Rows[0]["SALARIO"]));
        }

        public void Update(Cargo cargo)
        {
            ConexionBD.SetData("UPDATE CARGOS SET NOMBRE = '" + cargo.Nombre + "', " +
                "SALARIO = " + cargo.Salario + " WHERE ID_CARGO = " + cargo.Id, out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }
        
    }
}
