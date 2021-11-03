using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.App.Dominio
{
    public class Persona:Object
    {
        public int Id_Persona { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Dni { get; set; }
        public DateTime FechaNac { get; set; }

        public Persona()
        {

        }

    }
}
