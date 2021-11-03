using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Dominio
{
    public class Equipo
    {
        public int IdEquipo { get; set; }
        public String NombreEquipo { get; set; }

        public String Dt { get; set; }

        public List<Jugador> Jugadores { get; }

        public Equipo()
        {
            Jugadores = new List<Jugador>();

        }

        public void QuitarJugador(int nro)
        {
            Jugadores.RemoveAt(nro);
        }

        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }
    }
}
