using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApi.Repositories;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertaController : ControllerBase
    {
        private readonly IAlertaRepository _alertaRepository;

        public AlertaController(IAlertaRepository alertaRepository)
        {
            _alertaRepository = alertaRepository;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddAlerta(Alerta alerta)
        {
            await _alertaRepository.Add(alerta);
            return Ok();
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllAlertas()
        {
            var alertas = await _alertaRepository.GetAll();
            return Ok(alertas);
        }
    }
}
