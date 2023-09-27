namespace GestionEventosAcademicos.API
{

    class Eventos
    {

        class Evento
        {
            public string Nombre { get; set; }
            public DateTime Fecha { get; set; }
            public string Ubicacion { get; set; }
            public string Descripcion { get; set; }
            public string Tema { get; set; }
            public List<Sesion> Sesiones { get; set; } = new List<Sesion>();
        }


        class Sesion
        {
            public DateTime Hora { get; set; }
            public string Nombre { get; set; }
            public string Ponente { get; set; }
        }

        class Participante
        {
            public string Nombre { get; set; }
            public string AreaInteres { get; set; }
        }

        static List<Evento> eventos = new List<Evento>();
        static List<Participante> participantes = new List<Participante>();


    }

}