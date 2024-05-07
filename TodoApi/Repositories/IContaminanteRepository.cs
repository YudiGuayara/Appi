using System.Collections.Generic;
using System.Threading.Tasks; 

namespace TodoApi.Repositories;
public interface IContaminanteRepository
{
    Task<Contaminante> ObtenerContaminante(int id);
}