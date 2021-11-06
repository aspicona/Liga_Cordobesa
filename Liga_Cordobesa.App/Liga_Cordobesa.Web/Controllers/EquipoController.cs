﻿using Liga_Cordobesa.Backend.Dominio;
using Liga_Cordobesa.Backend.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : Controller
    {
        private IEquipoService service;

        public EquipoController()
        {
            service = new EquipoService();
        }

        [HttpGet("posiciones")]
        public IActionResult GetPosiciones()
        {
            return Ok(service.ObtenerPosiciones());
        }

        [HttpGet("proxID")]
        public IActionResult GetProximoEquipoID()
        {
            return Ok(service.ObtenerProximoEquipoID());
        }

        [HttpPost()]
        public IActionResult SaveEquipo(Equipo equipo)
        {
            if (equipo == null)
            {
                return BadRequest("Datos del Equipo son Requeridos!!");
            }

            return Ok(service.GrabarEquipo(equipo));
        }
    }
}