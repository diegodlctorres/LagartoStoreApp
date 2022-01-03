using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LagartoStoreApp
{
    public static class ConexionBD
    {
        private static MySqlConnection conexionBD;
        private static string connectionString = "datasource=localhost;port=3306;username=root;password=021217;database=lagartobd";

        public static MySqlConnection GetConexionBD()
        {
            try
            {
                if (conexionBD is null) conexionBD = new MySqlConnection(connectionString);

                conexionBD.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySql Connection: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            return conexionBD;
        }



        public static DataSet GetData(string SQL)
        {
            DataSet dataSet = new DataSet();
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(SQL, GetConexionBD());
                mySqlCommand.CommandType = CommandType.Text;
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                mySqlDataAdapter.Fill(dataSet);                
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySql Connection: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conexionBD.Close();
            }
            return dataSet;
        }

        public static DataSet GetData(string SQL, List<DBParametro> parametros)
        {
            DataSet dataSet = new DataSet();
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(SQL, GetConexionBD());
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                    parametros.ForEach(x => mySqlCommand.Parameters.AddWithValue(x.Nombre, x.Valor));

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                mySqlDataAdapter.Fill(dataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySql Connection: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conexionBD.Close();
            }
            return dataSet;
        }

        public static void SetData(string SQL)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(SQL, GetConexionBD());
                mySqlCommand.CommandType = CommandType.Text;
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySql Connection: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public static void SetData(string SQL, List<DBParametro> parametros)
        {
            DataSet dataSet = new DataSet();
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(SQL, GetConexionBD());
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                    parametros.ForEach(x => mySqlCommand.Parameters.AddWithValue(x.Nombre, x.Valor));
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySql Connection: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
