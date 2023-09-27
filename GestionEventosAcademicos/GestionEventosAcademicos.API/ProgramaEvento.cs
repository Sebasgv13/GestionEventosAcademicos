namespace GestionEventosAcademicos.API
{

    public class ProgramaEvento
    {
        public string NombreEvento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<Sesion> Sesiones { get; set; }
    }

    public class Sesion
    {
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string Tema { get; set; }
        public List<Ponente> Ponentes { get; set; }
    }

    public class Ponente
    {
        public string Nombre { get; set; }
        public string Profesion { get; set; }
    }

}
