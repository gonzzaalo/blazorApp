using BlazorAppVSCode.Class;
using BlazorAppVSCode.Interfaces;
using BlazorAppVSCode.Models.Commons;
using System.Text.Json;

namespace BlazorAppVSCode.Services
{
    public class MateriaService : GenericService<Materia>, IMateriaService
    {
        private readonly HttpClient client;
        private readonly JsonSerializerOptions options;
        private readonly string _endpoint;

        public MateriaService(HttpClient client): base(client) 
        {
            this.client = client;
            this.options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            this._endpoint = ApiEndpoints.GetEndpoint(nameof(Materia));
        }
        
        public async Task<List<Materia>?> GetByAnioCarreraAsync(int? idCarrera)
        {
            var response = await client.GetAsync($"{_endpoint}?idAnioCarrera={idCarrera}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<Materia>>(content, options); ;
        }
    }
}
