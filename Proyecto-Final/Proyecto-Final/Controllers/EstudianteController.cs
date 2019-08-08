using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;

namespace Proyecto_Final.Controllers
{
    [Route("Estudiantecontroller")]
    public class StudentController : Controller
    {
        private readonly IEstudianteService _estudianteService;

        public StudentController(IEstudianteService studentService)
        {
            _estudianteService = studentService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                _estudianteService.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                _estudianteService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Estudiante Model)
        {
            return Ok(
                _estudianteService.Add(Model)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] Estudiante Model)
        {
            return Ok(
                _estudianteService.Add(Model)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _estudianteService.Delete(id)
            );
        }
    }
}