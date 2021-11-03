using Liga_Cordobesa.Backend.Servicios.Implementaciones;
using Liga_Cordobesa.Backend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Servicios
{
    public class ServiceFactoryImp : AbstractServiceFactory
    {
        public override IEquipoService CrearEquipoService() => new EquipoService();
        public override IUsuarioService CrearUsuarioService() => new UsuarioService();
    }
}
