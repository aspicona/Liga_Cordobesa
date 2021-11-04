using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liga_Cordobesa.Backend.Servicios.Interfaces;
using Liga_Cordobesa.Backend.Servicios.Implementaciones;
using Liga_Cordobesa.Backend.Servicios;

namespace Liga_Cordobesa.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioService service;

        public UsuariosController()
        {
            service = new UsuarioService();
        }

        [HttpPost]
        public IActionResult PostLogin(List<Parametro> param)
        {
            if (param == null || param.Count == 0)
            {
                return BadRequest();
            }

            string user = "";
            string pass = "";
            
            foreach(Parametro prm in param)
            {
                if("usuario".Equals(prm.Nombre))
                {
                    user = prm.Valor.ToString();
                }
                else if ("contraseña".Equals(prm.Nombre))
                {
                    pass = prm.Valor.ToString();
                }
            }
            
            if (service.Login(user, pass))
            {
                return Ok(true);
            }
            else
            {
                return Ok(false);
            }
        }
    }
}
