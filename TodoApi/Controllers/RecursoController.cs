using Microsoft.AspNetCore.Mvc;
using TodoApi.Repositories;
using TodoApi.Services; 

namespace TodoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecursoController : ControllerBase
{
    private readonly RecursoService _recursoService;

    public RecursoController(RecursoService recursoService)
    {
        _recursoService = recursoService;
    }

    [HttpPost]
    public async Task<IActionResult> AgregarRecurso(Recurso recurso)
    {
        await _recursoService.AgregarRecurso(recurso);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> EliminarRecurso(int id)
    {
        await _recursoService.EliminarRecurso(id);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> ActualizarRecurso(int id, Recurso recurso)
    {
        recurso.Id = id;
        await _recursoService.ActualizarRecurso(recurso);
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> BuscarRecurso(int id)
    {
        var recurso = await _recursoService.BuscarRecurso(id);
        return Ok(recurso);
    }
}
 