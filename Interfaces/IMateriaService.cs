using BlazorAppVSCode.Models.Commons;

namespace BlazorAppVSCode.Interfaces
{
    public interface IMateriaService : IGenericService<Materia>
    {
        public Task<List<Materia>?> GetByAnioCarreraAsync(int? id);
    }
}
