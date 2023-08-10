using System.ComponentModel.DataAnnotations;

namespace ClinicaDental01.Models.Domain
{
    public class Servicio
    {
        [Key]
        public int IdServicio { get; set; }

        public string NombreServicio { get; set; }

        public string DescripcionServicio { get; set; }

        public long CostoServicio { get; set; }

    }


}
