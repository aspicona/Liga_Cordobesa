using Liga_Cordobesa.Backend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Servicios
{
    public abstract class AbstractServiceFactory
    {
        public abstract IEquipoService CrearEquipoService();
        public abstract IUsuarioService CrearUsuarioService();
        public abstract IPersonaService CrearPersonaService();
    }
}
