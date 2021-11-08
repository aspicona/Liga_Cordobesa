using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Dominio
{
    public class JugadoresDTO
    {
        public int Id_jugador { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Dni { get; set; }
        public DateTime FechaNac { get; set; }
        public String NombreEquipo { get; set; }
        public int Camiseta { get; set; }
        public String NombrePosicion { get; set; }
        public int Id_persona { get; set; }
    }
}
