using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.App.Servicios
{
    public abstract class AbstractServiceFactory
    {
        public abstract IService CrearService();

    }
}
