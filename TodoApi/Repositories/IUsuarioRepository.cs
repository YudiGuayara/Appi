public interface IUsuarioRepository
{
    Task<bool> Registrar(Usuario usuario);
    Task<bool> IniciarSesion(string correo, string contraseña);
    Task<bool> CerrarSesion();
}
