using Microsoft.EntityFrameworkCore;
using GestionEventosAcademicos.Shared.Entities;


namespace GestionEventosAcademicos.API.Data
{
    public class DataContext : DbContext
    {
        //Utilizar  las propiedades y opciones de DBContext
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }
        public DbSet<EventoAcademico> evento_academico { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}