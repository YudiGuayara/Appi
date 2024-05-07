using System.Threading.Tasks; 
using TodoApi.Repositories;
using TodoApi.Controllers; 


 
namespace TodoApi.Services
{
    public class ContaminanteService : IContaminanteRepository
    {
        private readonly IContaminanteRepository _contaminanteRepository;

        public ContaminanteService(IContaminanteRepository contaminanteRepository)
        {
            _contaminanteRepository = contaminanteRepository;
        }

        public async Task<Contaminante> ObtenerContaminante(int id)
        {
            return await _contaminanteRepository.ObtenerContaminante(id);
        }
    }
}