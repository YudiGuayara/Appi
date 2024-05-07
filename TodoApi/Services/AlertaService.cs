using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApi.Repositories; 

namespace TodoApi.Services
{
    public class AlertaService : IAlertaRepository
    {
        private readonly IAlertaRepository _alertaRepository;

        public AlertaService(IAlertaRepository alertaRepository)
        {
            _alertaRepository = alertaRepository;
        }

        // Implementación del método Add(Alerta)
        public async Task Add(Alerta alerta)
        {
            await _alertaRepository.Add(alerta);
        }

        // Implementación del método GetAll()
        public async Task<List<Alerta>> GetAll()
        {
            return await _alertaRepository.GetAll();
        }

        // Aquí podrías implementar otros métodos de la interfaz si los necesitas
    }
}
