public interface IMedicionRepository
{
    Task<List<Medicion>> GetAll();
    Task<Medicion> GetById(int id);
    Task<bool> Add(Medicion medicion);
    Task<bool> Update(Medicion medicion);
    Task<bool> Delete(int id);
}