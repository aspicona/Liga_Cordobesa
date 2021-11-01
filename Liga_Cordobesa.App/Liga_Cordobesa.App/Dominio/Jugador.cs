using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.App.Dominio
{
    class Jugador
    {
        public int Id_Jugador { get; set; }
        public Persona Persona { get; set; }
        public int Camiseta { get; set; }

        public Posicion Posicion { get; set; }


        public Jugador()
        {

            Persona = new Persona();
            Camiseta = 0;
            Posicion = new Posicion();

        }

    }
}
