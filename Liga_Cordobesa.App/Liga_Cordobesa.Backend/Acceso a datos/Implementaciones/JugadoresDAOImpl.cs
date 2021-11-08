using Liga_Cordobesa.Backend.Acceso_a_datos.Interfaces;
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

namespace Liga_Cordobesa.Backend.Acceso_a_datos.Implementaciones
{
    public class JugadoresDAOImpl : IJugadoresDAO
    {
        public bool EliminarJugador(int nro)
        {
            HelperDao dao = HelperDao.ObtenerInstancia();
            SqlConnection cnn = new SqlConnection(dao.PConn);
            SqlTransaction t = null;
            int affected = 0;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_DELETE_JUGADOR", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", nro);
                affected = cmd.ExecuteNonQuery();
                t.Commit();

            }
            catch (SqlException)
            {
                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return affected == 1;
        }

        public List<JugadoresDTO> FiltrarJugadores(List<Parametro> criterios)
        {
            List<JugadoresDTO> lst = new List<JugadoresDTO>();
            DataTable table = new DataTable();
            
            HelperDao helper = HelperDao.ObtenerInstancia();
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = helper.PConn;
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SP_JUGADORES_POR_EQUIPO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (Parametro p in criterios)
                {
                    if (p.Valor == null)
                        cmd.Parameters.AddWithValue(p.Nombre, DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue(p.Nombre, p.Valor.ToString());
                }

                table.Load(cmd.ExecuteReader());
                //mappear los registros como objetos del dominio:
                lst = RecorrerResultado(table);

                cnn.Close();
            }
            catch (SqlException)
            {
                lst = null;
            }
            return lst;
        }

        public bool InsertarJugador(Jugador jug, int idEquipo)
        {
            HelperDao helper = HelperDao.ObtenerInstancia();
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = helper.PConn;

            bool flag = true;
            try
            {
               cnn.Open();

               SqlCommand cmd = new SqlCommand("SP_INSERTAR_JUGADOR", cnn);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@id_persona", jug.Persona.Id_Persona);
               cmd.Parameters.AddWithValue("@camiseta", jug.Camiseta);
               cmd.Parameters.AddWithValue("@id_posicion", jug.Posicion.Id_posicion);
               cmd.Parameters.AddWithValue("@id_equipo", idEquipo);
               cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                flag = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return flag;
        }

        public List<JugadoresDTO> ObtenerJugadores()
        {
            HelperDao helper = HelperDao.ObtenerInstancia();
            DataTable table = helper.ConsultaSQL("SP_CONSULTAR_JUGADORES");

            return RecorrerResultado(table);
        }

        private List<JugadoresDTO> RecorrerResultado(DataTable table)
        {
            List<JugadoresDTO> lst = new List<JugadoresDTO>();

            foreach (DataRow row in table.Rows)
            {
                JugadoresDTO jugadorDTO = new JugadoresDTO();
                jugadorDTO.Id_jugador = Convert.ToInt32(row["id_jugador"].ToString());
                jugadorDTO.Nombre = row["nombre"].ToString();
                jugadorDTO.Apellido = row["apellido"].ToString();
                jugadorDTO.Dni = Convert.ToInt32(row["nro_doc"].ToString());
                jugadorDTO.FechaNac = Convert.ToDateTime(row["fecha_nac"]);
                jugadorDTO.NombreEquipo = row["nombre_equipo"].ToString();
                jugadorDTO.Camiseta = Convert.ToInt32(row["camiseta"].ToString());
                jugadorDTO.NombrePosicion = row["nombre_posicion"].ToString();
                jugadorDTO.Id_persona = Convert.ToInt32(row["id_persona"].ToString());

                lst.Add(jugadorDTO);
            }
            return lst;
        }
    }
}
