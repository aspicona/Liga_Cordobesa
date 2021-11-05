using Liga_Cordobesa.Backend.Acceso_a_datos.Interfaces;
using Liga_Cordobesa.Backend.Servicios.Implementaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Acceso_a_datos.Implementaciones
{
    class UsuarioDao : IUsuarioDao
    {
        public bool Login(string usuario, string contrasena)
        {
            HelperDao helper = HelperDao.ObtenerInstancia();
            SqlConnection cnn;
            cnn = new SqlConnection();
            cnn.ConnectionString = helper.PConn;

            bool esUsuario = false;

            try
            {
                cnn.Open();

                SqlCommand cmdEquipo = new SqlCommand("SP_VALIDAR_LOGIN", cnn);
                cmdEquipo.CommandType = CommandType.StoredProcedure;
                cmdEquipo.Parameters.AddWithValue("@nombreUsuario", usuario);
                cmdEquipo.Parameters.AddWithValue("@contrasena", contrasena);

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
