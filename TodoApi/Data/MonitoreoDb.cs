using Microsoft.EntityFrameworkCore;

namespace TodoApi.Data
{
    public class MonitoreoDb : DbContext
    {
        public MonitoreoDb(DbContextOptions<MonitoreoDb> options)
            : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; } 
        public DbSet<Medicion> Mediciones { get; set; }
        public DbSet<Contaminante> Contaminantes { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Alerta> Alertas { get; set; }
    }
} 