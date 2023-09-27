using System.Collections.Generic;


namespace GestionEventosAcademicos.API
{
    public class Participante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string AfiliacionInstitucional { get; set; }
        public string AreaDeInteres { get; set; }
        public TipoDeParticipacion TipoParticipacion { get; set; }
    }

    public enum TipoDeParticipacion
    {
        Ponente,
        Asistente
    }

}
