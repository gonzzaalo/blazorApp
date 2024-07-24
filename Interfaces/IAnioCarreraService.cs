using BlazorAppVSCode.Models;

namespace BlazorAppVSCode.Interfaces
{
    public interface IAnioCarreraService : IGenericService<AnioCarrera>
    {
        public Task<List<AnioCarrera>?> GetByCarreraAsync(int? id);
    }
}
