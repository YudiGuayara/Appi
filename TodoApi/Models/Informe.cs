public class Informe
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public string? Observacion { get; set; }
    public int IdUsuario { get; set; } // Referencia a Usuario
    public int IdMedicion { get; set; } // Referencia a Medicion
    public int IdAlerta { get; set; } // Referencia a Alerta
}