using Liga_Cordobesa.Backend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Servicios.Interfaces
{
    public interface IPersonaService
    {
        List<Persona> ConsultarPersonas();
        bool Insertar(Persona oPersona);
        bool UpdatePersona(Persona oPersona);
    }
}
