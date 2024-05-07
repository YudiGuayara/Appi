using Microsoft.AspNetCore.Mvc;
using TodoApi.Repositories;
using TodoApi.Services; 

namespace TodoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly EventoService _eventoService;

    public EventoController(EventoService eventoService)
    {
        _eventoService = eventoService;
    }

    [HttpGet("obtenerContaminante/{id}")]
    public async Task<IActionResult> ObtenerContaminante(int id)
    {
        var contaminante = await _eventoService.ObtenerContaminante(id);
        return Ok(contaminante);
    }
}
 