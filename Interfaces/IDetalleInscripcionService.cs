using BlazorAppVSCode.Models;

namespace BlazorAppVSCode.Interfaces
{
    public interface IDetalleInscripcionService : IGenericService<DetalleInscripcion>
    {
        public Task<List<DetalleInscripcion>?> GetByInscripcionAsync(int? id);
        public Task<bool> CheckDuplicadoDetalleInscripcionAsync(int? idInscripcion, int? idMateria);
    }
}
