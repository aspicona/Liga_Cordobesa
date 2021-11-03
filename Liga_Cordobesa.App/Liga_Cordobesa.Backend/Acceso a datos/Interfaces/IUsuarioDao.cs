using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Acceso_a_datos.Interfaces
{
    interface IUsuarioDao
    {
        bool Login(string usuario, string contrasena);
    }
}
