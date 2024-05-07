using System.Collections.Generic;
using System.Threading.Tasks;

public class MedicionService : IMedicionRepository
{
    private readonly IMedicionRepository _medicionRepository;

    public MedicionService(IMedicionRepository medicionRepository)
    {
        _medicionRepository = medicionRepository;
    }

    public async Task<List<Medicion>> GetAll()
    {
        // Lógica para obtener todas las mediciones
        return await _medicionRepository.GetAll();
    }

    public async Task<Medicion> GetById(int id)
    {
        // Lógica para obtener una medición por su ID
        return await _medicionRepository.GetById(id);
    }

    public async Task<bool> Add(Medicion medicion)
    {
        // Lógica para agregar una nueva medición
        return await _medicionRepository.Add(medicion);
    }

    public async Task<bool> Update(Medicion medicion)
    {
        // Lógica para actualizar una medición existente
        return await _medicionRepository.Update(medicion);
    }

    public async Task<bool> Delete(int id)
    {
        // Lógica para eliminar una medición por su ID
        return await _medicionRepository.Delete(id);
    }
}
