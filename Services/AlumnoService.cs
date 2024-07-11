using BlazorAppVSCode.Models;
using System.Text.Json;

namespace BlazorAppVSCode.Services
{
    public class AlumnoService : IAlumnoService
    {
        private readonly HttpClient client;
        private readonly JsonSerializerOptions options;

        public AlumnoService(HttpClient client)
        {
            this.client = client;
            this.options = new JsonSerializerOptions() { PropertyNameCaseInsensitive=true};
        }
        public async Task<List<Alumno>?> Get()
        {
            var response = await client.GetAsync("apialumnos");
            return await JsonSerializer.DeserializeAsync<List<Alumno>>(await response.Content.ReadAsStreamAsync());
        }
    }

    public interface IAlumnoService
    {
        public Task<List<Alumno>?> Get();
    }
}
