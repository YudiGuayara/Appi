public interface IRecursoRepository
{
    Task<bool> AgregarRecurso(Recurso recurso);
    Task<bool> EliminarRecurso(int id);
    Task<bool> ActualizarRecurso(Recurso recurso);
    Task<Recurso> BuscarRecurso(int id);
}