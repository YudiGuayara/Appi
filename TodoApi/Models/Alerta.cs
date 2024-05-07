public class Alerta
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public string? Nivel { get; set; }
    public string? Mensaje { get; set; }
    public int IdUsuario { get; set; }
    public int IdEvento { get; set; }
}