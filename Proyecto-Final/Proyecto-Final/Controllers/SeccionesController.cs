using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;

namespace Proyecto_Final.Controllers
{
    [Route("Seccionescontroller")]
    public class SeccionesController : Controller
    {
        private readonly ISeccionesService _seccionesService;

        public SeccionesController(ISeccionesService seccionesService)
        {
            _seccionesService = seccionesService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                _seccionesService.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                _seccionesService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Secciones Model)
        {
            return Ok(
                _seccionesService.Add(Model)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] Secciones Model)
        {
            return Ok(
                _seccionesService.Add(Model)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _seccionesService.Delete(id)
            );
        }
    }
}