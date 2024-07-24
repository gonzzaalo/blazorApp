namespace BlazorAppVSCode.Class
{
    public static class ApiEndpoints
    {
        public static string Carrera { get; set; } = "apicarreras";
        public static string Alumno { get; set; } = "apialumnos";
        public static string AnioCarrera { get; set; } = "apianiocarreras";
        public static string Materia { get; set; } = "apimaterias";
        public static string Inscripcion { get; set; } = "apiinscripciones";

        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(Carrera) => Carrera,
                nameof(Alumno) => Alumno,
                nameof(AnioCarrera) => AnioCarrera,
                nameof(Materia) => Materia,
                nameof(Inscripcion) => Inscripcion,
                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}
