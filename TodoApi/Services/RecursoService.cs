using System.Threading.Tasks;

public class RecursoService : IRecursoRepository
{
    private readonly IRecursoRepository _recursoRepository;

    public RecursoService(IRecursoRepository recursoRepository)
    {
        _recursoRepository = recursoRepository;
    }

    public async Task<bool> AgregarRecurso(Recurso recurso)
    {
        // Lógica para agregar un recurso
        return await _recursoRepository.AgregarRecurso(recurso);
    }

    public async Task<bool> EliminarRecurso(int id)
    {
        // Lógica para eliminar un recurso
        return await _recursoRepository.EliminarRecurso(id);
    }

    public async Task<bool> ActualizarRecurso(Recurso recurso)
    {
        // Lógica para actualizar un recurso
        return await _recursoRepository.ActualizarRecurso(recurso);
    }

    public async Task<Recurso> BuscarRecurso(int id)
    {
        // Lógica para buscar un recurso por su ID
        return await _recursoRepository.BuscarRecurso(id);
    }
}
