using Liga_Cordobesa.Backend.Acceso_a_datos.Implementaciones;
using Liga_Cordobesa.Backend.Acceso_a_datos.Interfaces;
using Liga_Cordobesa.Backend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Servicios.Implementaciones
{
    class UsuarioService : IUsuarioService
    {
        private IUsuarioDao dao;

        public UsuarioService()
        {
            dao = new UsuarioDao();
        }

        public bool Login(string usuario, string contrasena)
        {
            return dao.Login(usuario, contrasena);
        }
    }
}
