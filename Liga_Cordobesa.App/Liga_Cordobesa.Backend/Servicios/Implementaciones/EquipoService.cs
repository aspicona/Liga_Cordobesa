using Liga_Cordobesa.Backend.Acceso_a_datos;
using Liga_Cordobesa.Backend.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Servicios
{
    public class EquipoService : IEquipoService
    {
        private IEquipoDao dao;
        Persona oPersona;

        public EquipoService()
        {
            dao = new EquipoDao();            
        }

        public List<Equipo> ConsultarEquipo(List<Parametro> criterios)
        {
            return dao.ConsultarEquipo(criterios);
        }

        public List<Persona> ConsultarPersonas()
        {
            return dao.TraerPersonas();
        }

        public bool GrabarEquipo(Equipo oEquipo)
        {
            return dao.Guardar(oEquipo);
        }

        public bool Insertar(Persona oPersona)
        {
            SqlTransaction transaccion = null;
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-NDS3RE4;Initial Catalog=LigaCordobesa;Integrated Security=True");

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

        public Equipo ObtenerEquipoPorID(int nro)
        {
            throw new NotImplementedException();
        }

        public int ObtenerProximoEquipoID()
        {
            throw new NotImplementedException();
        }

        public bool RegistrarBajaEquipo(int presupuesto)
        {
            throw new NotImplementedException();
        }
    }

    //        public Equipo ObtenerEquipoPorID(int nro)
    //        {
    //            return service.EquipoPorId(nro);
    //        }

    //        public int ObtenerProximoEquipoID()
    //        {
    //            return dao.TraerNroEquipo();
    //        }

    //        public bool RegistrarBajaEquipo(int presupuesto)
    //        {
    //            return dao.Delete(presupuesto);
    //        }


    //    }
    //}
}