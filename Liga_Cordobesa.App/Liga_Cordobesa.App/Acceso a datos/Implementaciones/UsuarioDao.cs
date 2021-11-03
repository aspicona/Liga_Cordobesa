using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Acceso_a_datos.Implementaciones
{
    class UsuarioDao
    {
        public bool Login(string usuario, string contrasena)
        {
            SqlConnection cnn;
            cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=DESKTOP-NDS3RE4;Initial Catalog=LigaCordobesa;Integrated Security=True";

            bool esUsuario = false;

            try
            {
                cnn.Open();

                SqlCommand cmdEquipo = new SqlCommand("SP_VALIDAR_LOGIN", cnn);
                cmdEquipo.CommandType = CommandType.StoredProcedure;
                cmdEquipo.Parameters.AddWithValue("@nombreUsuario", "andres");
                cmdEquipo.Parameters.AddWithValue("@contrasena", "12345");

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@existe";
                param.SqlDbType = SqlDbType.Bit;
                param.Direction = ParameterDirection.Output;

                cmdEquipo.Parameters.Add(param);
                cmdEquipo.ExecuteNonQuery();

                esUsuario = (bool)param.Value;
            }
            catch (Exception e)
            {
                esUsuario = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            /*HelperDao helper = HelperDao.ObtenerInstancia();
            helper.EjecutarSQLConOutput("", "");*/
            return esUsuario;
        }
    }
}
