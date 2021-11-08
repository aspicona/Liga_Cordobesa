using Liga_Cordobesa.Backend.Dominio;
using Liga_Cordobesa.Backend.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Acceso_a_datos.Interfaces
{
    public interface IJugadoresDAO
    {
        List<JugadoresDTO> ObtenerJugadores();
        List<JugadoresDTO> FiltrarJugadores(List<Parametro> criterios);
        bool InsertarJugador(Jugador jugador, int idEquipo);
        bool EliminarJugador(int nro);
    }
}
