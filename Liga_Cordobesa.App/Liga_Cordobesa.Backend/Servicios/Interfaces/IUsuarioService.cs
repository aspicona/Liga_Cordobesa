using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Servicios.Interfaces
{
    public interface IUsuarioService
    {
        bool Login(string usuario, string contrasena);
    }
}