using BlazorAppVSCode.Models;

namespace BlazorAppVSCode.Interfaces
{
    public interface IMateriaService : IGenericService<Materia>
    {
        public Task<List<Materia>?> GetByAnioCarreraAsync(int? id);
    }
}
