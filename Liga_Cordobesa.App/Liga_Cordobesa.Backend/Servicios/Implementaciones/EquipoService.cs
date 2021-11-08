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

        public bool GrabarEquipo(Equipo oEquipo)
        {
            return dao.Guardar(oEquipo);
        }

        public Equipo ObtenerEquipoPorID(int nro)
        {
            return dao.EquipoPorId(nro);
        }

        public List<Equipo> ObtenerEquipos()
        {
            return dao.ObtenerEquipos();
        }

        public int ObtenerProximoEquipoID()
        {
            return dao.TraerNroEquipo();
        }

        public bool RegistrarBajaEquipo(int presupuesto)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEquipo(Equipo oEquipo)
        {
            return dao.Actualizar(oEquipo);
        }

        List<Posicion> IEquipoService.ObtenerPosiciones()
        {
            return dao.TraerPosicion();
        }
    }
}