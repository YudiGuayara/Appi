using System.Threading.Tasks;
using TodoApi.Repositories;

public class UsuarioService : IUsuarioRepository
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public async Task<bool> Registrar(Usuario usuario)
    {
        // Lógica para registrar un usuario
        return await _usuarioRepository.Registrar(usuario);
    }

    public async Task<bool> IniciarSesion(string correo, string contraseña)
    {
        // Lógica para iniciar sesión
        return await _usuarioRepository.IniciarSesion(correo, contraseña);
    }

    public async Task<bool> CerrarSesion()
    {
        // Lógica para cerrar sesión
        return await _usuarioRepository.CerrarSesion();
    }
}
