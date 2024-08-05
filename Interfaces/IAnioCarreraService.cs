
using BlazorAppVSCode.Models.Commons;

namespace BlazorAppVSCode.Interfaces
{
    public interface IAnioCarreraService : IGenericService<AnioCarrera>
    {
        public Task<List<AnioCarrera>?> GetByCarreraAsync(int? id);
    }
}
