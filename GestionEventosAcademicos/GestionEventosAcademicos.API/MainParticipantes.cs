namespace GestionEventosAcademicos.API
{
    public class MainParticipantes
    {
        static void Main()
        {
            using (var context = new EventosContext())
            {
                var nuevoParticipante = new Participante
                {
                    Nombre = "Yessenia Camargo",
                    AfiliacionInstitucional = "ITM",
                    AreaDeInteres = "Desarrollo de software",
                    TipoParticipacion = TipoDeParticipacion.Ponente
                };

                context.Participantes.Add(nuevoParticipante);
                context.SaveChanges();
            }

            Console.WriteLine("Se registro con Exito.");
        }
    }


}


