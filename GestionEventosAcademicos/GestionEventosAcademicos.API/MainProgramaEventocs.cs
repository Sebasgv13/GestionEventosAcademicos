namespace GestionEventosAcademicos.API
{
    public class MainProgramaEventocs
    {
   
            static void Main()
        {
            var programaEvento = new ProgramaEvento
            {
                NombreEvento = "Practica 2",
                FechaInicio = new DateTime(2023, 09, 27),
                FechaFin = new DateTime(2023, 09, 30),
                Sesiones = new List<Sesion>
            {
                new Sesion
                {
                    HoraInicio = new DateTime(2023, 09, 27, 6, 0, 0),
                    HoraFin = new DateTime(2023, 09, 30, 12, 00, 0),
                    Tema = "Desarrollo",
                    Ponentes = new List<Ponente>
                    {
                        new Ponente
                        {
                            Nombre = "Sebastian",
                            Profesion = "Estudiante Desarrollo de Software"
                        },
                        new Ponente
                        {
                            Nombre = "Yessenia Camargo",
                            Profesion = "Estudiante Desarrollo de Software"
                        }
                    }
                },

            }
            };


            Console.WriteLine("Nombre del Evento: " + programaEvento.NombreEvento);
            Console.WriteLine("Fecha inicial: " + programaEvento.FechaInicio);
            Console.WriteLine("Fecha final " + programaEvento.FechaFin);


            foreach (var sesion in programaEvento.Sesiones)
            {
                Console.WriteLine("Sesión: " + sesion.Tema);
                Console.WriteLine("Hora inicial: " + sesion.HoraInicio);
                Console.WriteLine("Hora final: " + sesion.HoraFin);

                Console.WriteLine("Ponentes:");
                foreach (var ponente in sesion.Ponentes)
                {
                    Console.WriteLine("- Nombre: " + ponente.Nombre);
                    Console.WriteLine("  Profesion: " + ponente.Profesion);
                }
            }
        }
    }

}

