using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApi.Controllers; 

namespace TodoApi.Repositories
{
    public interface IAlertaRepository
    {
        Task Add(Alerta alerta);
        Task<List<Alerta>> GetAll();
    }
}

