using Microsoft.AspNetCore.Mvc;
using TodoApi.Repositories;
using TodoApi.Services; 

namespace TodoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContaminanteController : ControllerBase
{
    private readonly ContaminanteService _contaminanteService;

    public ContaminanteController(ContaminanteService contaminanteService)
    {
        _contaminanteService = contaminanteService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObtenerContaminante(int id)
    {
        var contaminante = await _contaminanteService.ObtenerContaminante(id);
        return Ok(contaminante);
    }
}
