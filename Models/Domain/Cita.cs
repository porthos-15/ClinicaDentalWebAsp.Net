using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaDental01.Models.Domain
{
    public class Cita
    {
        [Key]
        public int IdCita { get; set; }

        public DateTime FechaCita { get; set; }

        public string DescripcionCita { get; set; }

    }
}
