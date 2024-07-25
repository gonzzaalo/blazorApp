using BlazorAppVSCode.Class;
using BlazorAppVSCode.Interfaces;
using BlazorAppVSCode.Models;
using System.Text.Json;

namespace BlazorAppVSCode.Services
{
    public class DetalleInscripcionService : GenericService<DetalleInscripcion>, IDetalleInscripcionService
    {
        private readonly HttpClient client;
        private readonly JsonSerializerOptions options;
        private readonly string _endpoint;

        public DetalleInscripcionService(HttpClient client): base(client) 
        {
            this.client = client;
            this.options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            this._endpoint = ApiEndpoints.GetEndpoint(nameof(DetalleInscripcion));
        }
        
        public async Task<List<DetalleInscripcion>?> GetByInscripcionAsync(int? idInscripcion)
        {
            var response = await client.GetAsync($"{_endpoint}?idInscripcion={idInscripcion}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<DetalleInscripcion>>(content, options); ;
        }
    }
}
