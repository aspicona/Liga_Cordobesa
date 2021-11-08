using Liga_Cordobesa.Backend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Servicios.Interfaces
{
    public interface IJugadoresService
    {
        List<JugadoresDTO> ObtenerJugadores();
        List<JugadoresDTO> FiltrarJugadores(List<Parametro> criteria);
        bool InsertarJugador(Jugador jugador, int idEquipo);
        bool DeleteJugador(int id);
    }
}
