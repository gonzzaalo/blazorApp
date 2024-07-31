using BlazorAppVSCode.Interfaces.Commons;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppVSCode.Models
{
    public class AnioCarrera : IEntityIdNombre
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int? CarreraId { get; set; }
        public Carrera? Carrera { get; set; }
        [NotMapped]
        public string AñoYCarrera {
            get { return $"{Nombre} {Carrera?.Nombre}" ?? string.Empty; } 
        }
        public override string ToString()
        {
            return AñoYCarrera;
        }
    }
}
