using BlazorAppVSCode.Models;

namespace BlazorAppVSCode.Interfaces
{
    public interface IMesaExamenService : IGenericService<MesaExamen>
    {
        public Task<List<MesaExamen>?> GetByTurnoAndCarreraAsync(int? idTurno, int? idCarrera);
    }
}
