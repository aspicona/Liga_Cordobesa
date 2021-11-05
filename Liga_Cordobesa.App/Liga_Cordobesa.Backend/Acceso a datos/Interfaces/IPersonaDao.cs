using Liga_Cordobesa.Backend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Acceso_a_datos.Interfaces
{
    public interface IPersonaDao
    {
        public List<Persona> TraerPersonas();
        public bool Insertar(Persona oPersona);
    }
}
