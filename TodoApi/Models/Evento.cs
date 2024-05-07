public class Evento
{
    public int Id { get; set; }
    public string? Descripcion { get; set; }
    public int Magnitud { get; set; }
    public DateTime Fecha { get; set; }
    public int IdContaminante { get; set; }
    public int IdRecurso { get; set; }
}