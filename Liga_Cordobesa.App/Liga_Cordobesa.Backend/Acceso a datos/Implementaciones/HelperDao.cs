using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Servicios.Implementaciones
{
    class HelperDao
    {
        private static HelperDao instancia;
        private string connectionString;
        
        private HelperDao()
        {
            connectionString = @"Data Source=DESKTOP-CLVH0O5\SQLEXPRESS;Initial Catalog=LigaCordobesa;Integrated Security=True";
        }

        public string PConn { get { return connectionString; } set { connectionString = value; } }

        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }

        public int EjecutarSQLConOutput(string nombreSP, string nombreParametros)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlParameter param = new SqlParameter();
            int val;
            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;
                param.ParameterName = nombreParametros;
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(param);
                cmd.ExecuteScalar();
                val = (int) param.Value;
            }
            catch (Exception)
            {
                val = 0;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return val;
        }


        public DataTable ConsultaSQL(string storeName)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;
                tabla.Load(cmd.ExecuteReader());
                return tabla;

            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
