using System.ComponentModel.DataAnnotations;

namespace BlazorAppVSCode.Models
{
    public class Carrera
    {
        public int id { get; set; }
        [Required(ErrorMessage = "El nombre debe cargarse obligatoriamente")]
        public string nombre { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"id:{id} nombre:{nombre}";
        }
    }
}
