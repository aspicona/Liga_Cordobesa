using Liga_Cordobesa.Backend.Acceso_a_datos.Implementaciones;
using Liga_Cordobesa.Backend.Acceso_a_datos.Interfaces;
using Liga_Cordobesa.Backend.Dominio;
using Liga_Cordobesa.Backend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Servicios.Implementaciones
{
    public class JugadoresServiceImpl : IJugadoresService
    {
        private IJugadoresDAO dao;
        JugadoresDTO jugadoresDTO;

        public JugadoresServiceImpl()
        {
            dao = new JugadoresDAOImpl();
        }

        public List<JugadoresDTO> FiltrarJugadores(List<Parametro> criteria)
        {
            return dao.FiltrarJugadores(criteria);
        }

        public bool InsertarJugador(Jugador jugador, int idEquipo)
        {
            return dao.InsertarJugador(jugador, idEquipo);
        }

        public List<JugadoresDTO> ObtenerJugadores()
        {
            return dao.ObtenerJugadores();
        }
    }
}
