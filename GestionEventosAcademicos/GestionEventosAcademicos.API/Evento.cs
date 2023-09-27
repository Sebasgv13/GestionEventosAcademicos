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
    }
}