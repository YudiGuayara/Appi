using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicionController : ControllerBase
    {
        private readonly MedicionService _medicionService;

        public MedicionController(MedicionService medicionService)
        {
            _medicionService = medicionService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllMediciones()
        {
            var mediciones = await _medicionService.GetAll();
            return Ok(mediciones);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMedicionById(int id)
        {
            var medicion = await _medicionService.GetById(id);
            if (medicion == null)
            {
                return NotFound();
            }
            return Ok(medicion);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddMedicion(Medicion medicion)
        {
            var result = await _medicionService.Add(medicion);
            if (!result)
            {
                return BadRequest("No se pudo agregar la medición.");
            }
            return Ok();
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateMedicion(Medicion medicion)
        {
            var result = await _medicionService.Update(medicion);
            if (!result)
            {
                return BadRequest("No se pudo actualizar la medición.");
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicion(int id)
        {
            var result = await _medicionService.Delete(id);
            if (!result)
            {
                return BadRequest("No se pudo eliminar la medición.");
            }
            return Ok();
        }
    }
}
