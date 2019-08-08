using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;

namespace Proyecto_Final.Controllers
{
    [Route("Materiacontroller")]
    public class MateriaController : Controller
    {
        private readonly IMateriaService _materiaService;

        public MateriaController(IMateriaService materiaService)
        {
            _materiaService = materiaService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                _materiaService.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                _materiaService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Materia Model)
        {
            return Ok(
                _materiaService.Add(Model)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] Materia Model)
        {
            return Ok(
                _materiaService.Add(Model)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _materiaService.Delete(id)
            );
        }
    }
}