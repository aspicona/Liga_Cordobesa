using Liga_Cordobesa.Backend.Acceso_a_datos.Interfaces;
using Liga_Cordobesa.Backend.Dominio;
using Liga_Cordobesa.Backend.Servicios.Implementaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Liga_Cordobesa.Backend.Acceso_a_datos.Implementaciones
{
    public class PersonaDAOImpl : IPersonaDao
    {
        public bool Insertar(Persona oPersona)
        {
            HelperDao helper = HelperDao.ObtenerInstancia();
            SqlTransaction transaccion = null;
            SqlConnection cnn = new SqlConnection(helper.PConn);

            bool flag = true;
            try
            {
                cnn.Open();
                transaccion = cnn.BeginTransaction();

                SqlCommand cmd = new SqlCommand("SP_INSERTAR_PERSONA", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaccion;

                cmd.Parameters.AddWithValue("@nro_doc ", oPersona.Dni);
                cmd.Parameters.AddWithValue("@nombre", oPersona.Nombre);
                cmd.Parameters.AddWithValue("@apellido", oPersona.Apellido);
                cmd.Parameters.AddWithValue("@fecha_nac", oPersona.FechaNac);
                cmd.ExecuteNonQuery();

                transaccion.Commit();
            }

            catch
            {
                transaccion.Rollback();
                flag = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return flag;
        }

        public List<Persona> TraerPersonas()
        {
            HelperDao helper = HelperDao.ObtenerInstancia();
            DataTable table = helper.ConsultaSQL("SP_CONSULTAR_PERSONA");

            List<Persona> lst = new List<Persona>();

            foreach (DataRow row in table.Rows)
            {
                Persona oPersona = new Persona();
                oPersona.Id_Persona = Convert.ToInt32(row["id_persona"].ToString());
                oPersona.Nombre = row["nombre"].ToString();
                oPersona.Apellido = row["apellido"].ToString();
                oPersona.Dni = Convert.ToInt32(row["nro_doc"].ToString());
                oPersona.FechaNac = Convert.ToDateTime(row["fecha_nac"]);
                lst.Add(oPersona);
            }
            return lst;
        }
    }
}
