using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClinicaDental01.Models.Domain
{
    public class Dentista
    {
        [Key]
        public int IdDentista { get; set; }

        public string NombreDentista { get; set; }

        public string PrimerApellidoDentista { get; set; }

        public string SegundoApellidoDentista { get; set; }

        [Required]
        [EmailAddress]
        public string CorreoDentista { get; set; }

        public string TelefonoDentista { get; set; }





    }
}
