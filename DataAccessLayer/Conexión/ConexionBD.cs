using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer
{
    public static class ConexionBD
    {
        private static MySqlConnection conexionBD;
        private static readonly string connectionString = "datasource=localhost;port=3306;username=root;password=021217;database=lagartobd";

        public static MySqlConnection GetConexionBD()
        {
            try
            {
                if (conexionBD is null) conexionBD = new MySqlConnection(connectionString);

                conexionBD.Open();
            }
            catch (Exception) { throw; }
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
            catch (Exception) { throw; }
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
            catch (Exception) { throw; }
            finally
            {
                conexionBD.Close();
            }
            return dataSet;
        }

        public static void SetData(string SQL, out int rowsAfected)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(SQL, GetConexionBD());
                mySqlCommand.CommandType = CommandType.Text;
                rowsAfected = mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                conexionBD.Close();
            }
        }

        public static void SetData(string SQL, List<DBParametro> parametros, out int rowsAfected)
        {
            DataSet dataSet = new DataSet();
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(SQL, GetConexionBD());
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                    parametros.ForEach(x => mySqlCommand.Parameters.AddWithValue(x.Nombre, x.Valor));
                rowsAfected = mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
