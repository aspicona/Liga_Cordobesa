using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liga_Cordobesa.Backend.Servicios;
using Liga_Cordobesa.Backend.Servicios.Implementaciones;

namespace Liga_Cordobesa.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private IService service;

        public PersonaController()
        {
            service = new ServiceFactoryImp().CrearService();
        }

        [HttpGet()]
        public IActionResult GetPersonas()
        {
            return Ok(service.ConsultarPersonas());
        }
    }
}
