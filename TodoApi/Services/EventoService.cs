using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApi.Repositories;
using TodoApi.Controllers; 

namespace TodoApi.Services
{
    public class EventoService : IEventoRepository
    {
        private readonly IEventoRepository _eventoRepository;

        public EventoService(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public Task<Contaminante> ObtenerContaminante(int idEvento)
        {
            // Aquí iría la lógica real para obtener el contaminante según el idEvento
            // Por ahora, simplemente devolvemos null
            return Task.FromResult<Contaminante>(null);
        }
    }
}