using Liga_Cordobesa.Backend.Servicios;
using Liga_Cordobesa.Backend.Servicios.Implementaciones;
using Liga_Cordobesa.Backend.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadoresController : ControllerBase
    {
        private IJugadoresService service;

        public JugadoresController()
        {
            service = new JugadoresServiceImpl();
        }

        [HttpGet()]
        public IActionResult GetJugadores()
        {
            return Ok(service.ObtenerJugadores());
        }

        [HttpPost("filtro")]
        public IActionResult GetPresupuestos(List<Parametro> lst)
        {
            if (lst == null || lst.Count == 0)
                return BadRequest("Se requiere pasar el parametro!");

            return Ok(service.FiltrarJugadores(lst));
        }
    }
}
