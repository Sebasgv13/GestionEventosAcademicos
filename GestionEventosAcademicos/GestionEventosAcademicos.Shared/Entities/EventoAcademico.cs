using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEventosAcademicos.Shared.Entities
{
    public class EventoAcademico
    {
        [Key]public int IdEvento { get; set; }
        
        public String NombreEvento { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get;}

        public String Ubicacion { get; set; }

        public String Descripcion { get; set;}

        public String TemaEvento { get; set;}
       
    }
}
