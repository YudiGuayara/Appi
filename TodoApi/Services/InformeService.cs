using System.Threading.Tasks;

public class InformeService : IInformeRepository
{
    private readonly IInformeRepository _informeRepository;

    public InformeService(IInformeRepository informeRepository)
    {
        _informeRepository = informeRepository;
    }

    public async Task<bool> Add(Informe informe)
    {
        // Lógica para agregar un informe
        return await _informeRepository.Add(informe);
    }

    public async Task<bool> Update(Informe informe)
    {
        // Lógica para actualizar un informe
        return await _informeRepository.Update(informe);
    }

    public async Task<bool> Delete(int id)
    {
        // Lógica para eliminar un informe
        return await _informeRepository.Delete(id);
    }
}
