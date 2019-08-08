using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;

namespace Proyecto_Final.Controllers
{

    [Route("CarreraController")]
    public class CarreraController : Controller
    {
        private readonly ICarreraService _carreraService;

        public CarreraController(ICarreraService carreraService)
        {
            _carreraService = carreraService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                _carreraService.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                _carreraService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Carrera Model)
        {
            return Ok(
                _carreraService.Add(Model)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] Carrera Model)
        {
            return Ok(
                _carreraService.Add(Model)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _carreraService.Delete(id)
            );
        }
    }
}