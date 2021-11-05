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
    public class PersonaServiceImpl : IPersonaService
    {
        private IPersonaDao dao;

        public PersonaServiceImpl()
        {
            dao = new PersonaDAOImpl();
        }

        public List<Persona> ConsultarPersonas()
        {
            return dao.TraerPersonas();
        }

        public bool Insertar(Persona oPersona)
        {
            return dao.Insertar(oPersona);
        }
    }
}
