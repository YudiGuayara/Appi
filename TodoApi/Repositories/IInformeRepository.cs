// Puedes implementar estos servicios según las necesidades específicas de tu aplicación
// Por ejemplo, podrías necesitar métodos para crear, actualizar, eliminar y consultar informes.
// La implementación dependerá de los requisitos de tu sistema.
public interface IInformeRepository
{
    Task<bool> Add(Informe informe);
    Task<bool> Update(Informe informe);
    Task<bool> Delete(int id);
}