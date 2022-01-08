using LagartoStoreApp.BLL;
using System;
using System.Collections.Generic;
using System.Data;

namespace LagartoStoreApp.DAL
{
    public sealed class CuentaDAL : ICrud<Cuenta>
    {
        public void Create(Cuenta cuenta)
        {
            if (cuenta is null) throw new ArgumentNullException(nameof(cuenta));

            ConexionBD.SetData("INSERT INTO CUENTAS (ID_USUARIO, CONTRASEÑA, ID_USUARIO_REGISTRO) " +
                "VALUES (" + cuenta.Usuario.Id + ", '" + cuenta.Contraseña + "', " + 1 + ")", out int rows); 
                                //DEBE RECOGER EL CÓDIGO DEL USUARIO QUE ESTÁ LOGEADO

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }

        public void Delete(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            ConexionBD.SetData("DELETE FROM CUENTAS WHERE ID_CUENTA = " + id, out int rows);

            if (rows == 0) throw new Exception("No se eliminó ningún registro.");
        }

        public List<Cuenta> GetAll()
        {
            DataTable dataTable = ConexionBD.GetData("SELECT * FROM CUENTAS").Tables[0];

            List<Cuenta> cuentas = new List<Cuenta>();
            foreach (DataRow row in dataTable.Rows)
            {
                cuentas.Add(new Cuenta(Convert.ToInt32(row["ID_CUENTA"]),
                                       AppEngine.usuarioDAL.GetByID(Convert.ToInt32(row["ID_USUARIO"])),
                                       row["CONTRASEÑA"].ToString(),
                                       Convert.ToBoolean(row["FLG_ACTIVO"])));
            }

            return cuentas;
        }

        public Cuenta GetByID(int id)
        {
            if (id < 1) throw new Exception("El ID: " + id + " es incorrecto.");

            DataTable dataTable = ConexionBD.GetData("SELECT * FROM CUENTA WHERE ID_CUENTA = " + id).Tables[0];

            if (dataTable.Rows.Count == 0) throw new Exception("No se encontró la cuenta de ID: " + id + ".");

            return new Cuenta(Convert.ToInt32(dataTable.Rows[0]["ID_CUENTA"]),
                              AppEngine.usuarioDAL.GetByID(Convert.ToInt32(dataTable.Rows[0]["ID_USUARIO"])),
                              dataTable.Rows[0]["CONTRASEÑA"].ToString(),
                              Convert.ToBoolean(dataTable.Rows[0]["FLG_ACTIVO"]));
        }

        public void Update(Cuenta cuenta)
        {
            ConexionBD.SetData("UPDATE CUENTAS SET CONTRASEÑA = '" + cuenta.Contraseña + "', " +
                "FLG_ACTIVO = " + Convert.ToInt32(cuenta.IsActivo) + " WHERE ID_CUENTA = " + cuenta.Id, out int rows);

            if (rows == 0) throw new Exception("No se actualizó ningún registro.");
        }
    }
}
