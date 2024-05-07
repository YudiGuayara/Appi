public class Medicion
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Ph { get; set; }
    public decimal Temperatura { get; set; }
    public int IdUsuario { get; set; }
    public int IdContaminante { get; set; }
    public int IdRecurso { get; set; }
}