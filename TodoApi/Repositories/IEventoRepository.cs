using System.Collections.Generic;
using System.Threading.Tasks; 

namespace TodoApi.Services;
public interface IEventoRepository
{
    Task<Contaminante> ObtenerContaminante(int idEvento);
}