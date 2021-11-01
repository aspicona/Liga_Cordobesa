using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.App.Dominio
{
    class Posicion
    {
        public int Id_posicion { get; set; }
        public String NombrePosicion { get; set; }


        public Posicion()
        {
            Id_posicion = 0;
            NombrePosicion = "";
        }

    }
}
