using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liga_Cordobesa.Backend.Servicios;
using Liga_Cordobesa.Backend.Servicios.Implementaciones;
using Liga_Cordobesa.Backend.Dominio;
using Liga_Cordobesa.Backend.Servicios.Interfaces;

namespace Liga_Cordobesa.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private IPersonaService service;

        public PersonaController()
        {
            service = new ServiceFactoryImp().CrearPersonaService();
        }

        [HttpGet()]
        public IActionResult GetPersonas()
        {
            return Ok(service.ConsultarPersonas());
        }

        [HttpPost()]
        public IActionResult SavePersona(Persona persona)
        {
            if(persona == null)
            {
                return BadRequest("Datos de la persona son requeridos!!");
            }

            return Ok(service.Insertar(persona));
        }

    }
}
