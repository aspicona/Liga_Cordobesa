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
            HelperDao helper = HelperDao.ObtenerInstancia();
            SqlConnection cnn;
            cnn = new SqlConnection();
            cnn.ConnectionString = helper.PConn;

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

                int nroEquipo = (int) param.Value;

                foreach (Jugador jug in oEquipo.Jugadores)
                {
                    SqlCommand cmd = new SqlCommand("SP_INSERTAR_JUGADOR", cnn);
                    cmd.Transaction = transaccion;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_persona", jug.Persona.Id_Persona);
                    cmd.Parameters.AddWithValue("@camiseta", jug.Camiseta);
                    cmd.Parameters.AddWithValue("@id_posicion", jug.Posicion.Id_posicion);
                    cmd.Parameters.AddWithValue("@id_equipo", nroEquipo);                   
                    cmd.ExecuteNonQuery();
                }

                transaccion.Commit();
            }
            catch (Exception)
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

        public int TraerNroEquipo()
        {
            HelperDao helper = HelperDao.ObtenerInstancia();
            return helper.EjecutarSQLConOutput("SP_PROXIMO_ID_EQUIPO", "@next");
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

        public List<Equipo> ConsultarEquipo(List<Parametro> criterios)
        {
            return null;
        }

        public Equipo EquipoPorId(int id)
        {
            HelperDao helper = HelperDao.ObtenerInstancia();
            SqlConnection cnn;
            cnn = new SqlConnection();
            cnn.ConnectionString = helper.PConn;

            try
            {
                cnn.Open();

                SqlCommand cmdEquipo = new SqlCommand("SP_EQUIPO_BY_ID", cnn);
                cmdEquipo.CommandType = CommandType.StoredProcedure;
                cmdEquipo.Parameters.AddWithValue("@id", id);

                DataTable table = new DataTable();
                table.Load(cmdEquipo.ExecuteReader());

                Equipo oEquipo = new Equipo();
                oEquipo.IdEquipo = Convert.ToInt32(table.Rows[0]["id_equipo"].ToString());
                oEquipo.NombreEquipo = table.Rows[0]["nombre_equipo"].ToString();
                oEquipo.Dt = table.Rows[0]["dt"].ToString();

                return oEquipo;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public bool Delete(int nro)
        {
            HelperDao dao = HelperDao.ObtenerInstancia();
            SqlConnection cnn = new SqlConnection(dao.PConn);
            SqlTransaction t = null;
            int affected = 0;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_DELETE_EQUIPO", cnn, t);
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

            return affected > 0;
        }

        public List<Equipo> ObtenerEquipos()
        {
            HelperDao helper = HelperDao.ObtenerInstancia();
            DataTable table = helper.ConsultaSQL("SP_CONSULTAR_EQUIPO");

            List<Equipo> lst = new List<Equipo>();

            foreach (DataRow row in table.Rows)
            {
                Equipo equipo = new Equipo();
                equipo.IdEquipo = Convert.ToInt32(row["id_equipo"].ToString());
                equipo.NombreEquipo = row["nombre_equipo"].ToString();
                equipo.Dt = row["dt"].ToString();
                lst.Add(equipo);
            }
            return lst;
        }

        public bool Actualizar(Equipo oEquipo)
        {
            HelperDao helper = HelperDao.ObtenerInstancia();
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = helper.PConn;

            bool flag = true;
            try
            {
                cnn.Open();

                SqlCommand cmdEquipo = new SqlCommand("SP_UPDATE_EQUIPO", cnn);
                cmdEquipo.CommandType = CommandType.StoredProcedure;
                cmdEquipo.Parameters.AddWithValue("@nombre_equipo", oEquipo.NombreEquipo.ToString());
                cmdEquipo.Parameters.AddWithValue("@dt", oEquipo.Dt);
                cmdEquipo.Parameters.AddWithValue("@nro", oEquipo.IdEquipo);

                cmdEquipo.ExecuteNonQuery();
            }
            //catch (Exception)
            //{
            //    flag = false;
            //}
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return flag;
        }
    }
}
