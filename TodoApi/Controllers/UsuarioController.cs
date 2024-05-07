using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TodoApi.Data;
using TodoApi.Services;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("registrar")]
        public async Task<IActionResult> RegistrarUsuario(Usuario usuario)
        {
            var result = await _usuarioService.Registrar(usuario);
            if (!result)
            {
                return BadRequest("No se pudo registrar el usuario.");
            }
            return Ok();
        }

        [HttpPost("iniciar-sesion")]
        public async Task<IActionResult> IniciarSesion(string correo, string contraseña)
        {
            var result = await _usuarioService.IniciarSesion(correo, contraseña);
            if (!result)
            {
                return BadRequest("Inicio de sesión fallido. Verifique sus credenciales.");
            }
            return Ok();
        }

        [HttpPost("cerrar-sesion")]
        public async Task<IActionResult> CerrarSesion()
        {
            var result = await _usuarioService.CerrarSesion();
            if (!result)
            {
                return BadRequest("No se pudo cerrar sesión.");
            }
            return Ok();
        }
    }
}
