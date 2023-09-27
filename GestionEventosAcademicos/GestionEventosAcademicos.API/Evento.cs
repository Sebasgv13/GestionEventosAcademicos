namespace GestionEventosAcademicos.API
{

    using System;
    using System.Collections.Generic;

    class Program
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

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Registrar un evento");
                Console.WriteLine("2. Ver eventos registrados");
                Console.WriteLine("3. Registrar un participante");
                Console.WriteLine("4. Ver participantes registrados");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            RegistrarEvento();
                            break;
                        case 2:
                            VerEventos();
                            break;
                        case 3:
                            RegistrarParticipante();
                            break;
                        case 4:
                            VerParticipantes();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Opción no encontrada, intente nuevamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no encontrada, intente nuevamente.");
                }

                Console.WriteLine();
            }
        }

        static void RegistrarEvento()
        {
            Evento evento = new Evento();

            Console.Write("Nombre del evento: ");
            evento.Nombre = Console.ReadLine();

            Console.Write("Fecha del evento (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
            {
                evento.Fecha = fecha;
            }

            Console.Write("Lugar del evento: ");
            evento.Ubicacion = Console.ReadLine();

            Console.Write("Descripción del evento: ");
            evento.Descripcion = Console.ReadLine();

            Console.Write("Tema del evento: ");
            evento.Tema = Console.ReadLine();

            Console.WriteLine("Ingrese sesiones (Presione tecla enter para finalizar):");
            while (true)
            {
                Sesion sesion = new Sesion();

                Console.Write("Hora de la sesión (HH:mm): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime hora))
                {
                    sesion.Hora = hora;
                }

                Console.Write("Nombre de la sesión: ");
                sesion.Nombre = Console.ReadLine();

                Console.Write("Nombre del ponente: ");
                sesion.Ponente = Console.ReadLine();

                evento.Sesiones.Add(sesion);

                Console.Write("¿Desea agregar otra sesión? (S/N): ");
                string respuesta = Console.ReadLine();
                if (respuesta != null && respuesta.Trim().ToUpper() != "S")
                {
                    break;
                }
            }

            eventos.Add(evento);
            Console.WriteLine("Evento registrado con éxito.");
        }

        static void VerEventos()
        {
            Console.WriteLine("Eventos registrados:");
            foreach (var evento in eventos)
            {
                Console.WriteLine($"Nombre: {evento.Nombre}");
                Console.WriteLine($"Fecha: {evento.Fecha:yyyy-MM-dd}");
                Console.WriteLine($"Ubicación: {evento.Ubicacion}");
                Console.WriteLine($"Descripción: {evento.Descripcion}");
                Console.WriteLine($"Tema: {evento.Tema}");
                Console.WriteLine("Sesiones:");
                foreach (var sesion in evento.Sesiones)
                {
                    Console.WriteLine($"Hora: {sesion.Hora:HH:mm}, Sesión: {sesion.Nombre}, Ponente: {sesion.Ponente}");
                }
                Console.WriteLine();
            }
        }

        static void RegistrarParticipante()
        {
            Participante participante = new Participante();

            Console.Write("Nombre del participante: ");
            participante.Nombre = Console.ReadLine();

            Console.Write("Área de interés: ");
            participante.AreaInteres = Console.ReadLine();

            participantes.Add(participante);
            Console.WriteLine("Participante registrado con éxito.");
        }

        static void VerParticipantes()
        {
            Console.WriteLine("Participantes registrados:");
            foreach (var participante in participantes)
            {
                Console.WriteLine($"Nombre: {participante.Nombre}");
                Console.WriteLine($"Área de interés: {participante.AreaInteres}");
                Console.WriteLine();
            }
        }
    }
}
