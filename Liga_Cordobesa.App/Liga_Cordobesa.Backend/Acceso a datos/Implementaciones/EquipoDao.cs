using Liga_Cordobesa.Backend.Dominio;
using Liga_Cordobesa.Backend.Servicios;
using Liga_Cordobesa.Backend.Servicios.Implementaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Acceso_a_datos
{
    public class EquipoDao : IEquipoDao
    {
        public bool Guardar(Equipo oEquipo)
        {
            SqlConnection cnn;
            cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=DESKTOP-NDS3RE4;Initial Catalog=LigaCordobesa;Integrated Security=True";

            SqlTransaction transaccion = null;

            bool flag = true;
            try
            {
               cnn.Open();
               transaccion = cnn.BeginTransaction();

                SqlCommand cmdEquipo = new SqlCommand("SP_INSERTAR_EQUIPO", cnn, transaccion);
                cmdEquipo.CommandType = CommandType.StoredProcedure;
                cmdEquipo.Parameters.AddWithValue("@nombre_equipo", oEquipo.NombreEquipo.ToString());
                cmdEquipo.Parameters.AddWithValue("@dt", oEquipo.Dt);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@equipo_nro";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;

                cmdEquipo.Parameters.Add(param);
                cmdEquipo.ExecuteNonQuery();

                int nroEquipo = (int)param.Value;

                foreach (Jugador jug in oEquipo.Jugadores)
                {
                    SqlCommand cmd = new SqlCommand("SP_INSERTAR_JUGADOR", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaccion;
                    cmd.Parameters.AddWithValue("@id_persona", jug.Persona.Id_Persona);
                    cmd.Parameters.AddWithValue("@camiseta", jug.Camiseta);
                    cmd.Parameters.AddWithValue("@id_posicion", jug.Posicion.Id_posicion);
                    cmd.Parameters.AddWithValue("@id_equipo", nroEquipo);                   
                    cmd.ExecuteNonQuery();
                }

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

        public List<Persona> TraerPersona()
        {
            HelperDao helper = HelperDao.ObtenerInstancia();
            DataTable table = helper.ConsultaSQL("SP_CONSULTAR_PERSONA");

            List<Persona> lst = new List<Persona>();

            foreach (DataRow row in table.Rows)
            {
                Persona oPersona = new Persona();
                oPersona.Id_Persona= Convert.ToInt32(row["id_persona"].ToString());
                oPersona.Nombre = row["nombre"].ToString();
                oPersona.Apellido = row["apellido"].ToString();
                oPersona.Dni = Convert.ToInt32(row["nro_doc"].ToString());
                oPersona.FechaNac = Convert.ToDateTime(row["fecha_nac"]);
                lst.Add(oPersona);
            }
            return lst;
        }

        public int TraerNroEquipo()
        {
            HelperDao helper = HelperDao.ObtenerInstancia();
            return helper.EjecutarSQLConOutput("SP_PROXIMO_ID_EQUIPO", "@next");
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

        public List<Posicion> TraerPosicion()
        {
            HelperDao helper = HelperDao.ObtenerInstancia();
            DataTable table = helper.ConsultaSQL("SP_CONSULTAR_POSICION");

            List<Posicion> lstPosicion = new List<Posicion>();


            foreach (DataRow row in table.Rows)
            {
                Posicion oPosicion = new Posicion();
                oPosicion.Id_posicion = Convert.ToInt32(row["id_posicion"].ToString());
                oPosicion.NombrePosicion = row["nombre_posicion"].ToString();
                lstPosicion.Add(oPosicion);
            }

            return lstPosicion;
        }

        public bool Insertar(Persona oPersona)
        {

            SqlTransaction transaccion = null;
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-NDS3RE4;Initial Catalog=LigaCordobesa;Integrated Security=True");

            bool flag = true;
            try
            {
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

        public List<Equipo> ConsultarEquipo(List<Parametro> criterios)
        {
            throw new NotImplementedException();
        }

        public Equipo EquipoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int nro)
        {
            throw new NotImplementedException();
        }
    }
}
