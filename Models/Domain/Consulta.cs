using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClinicaDental01.Models.Domain
{
    public class Consulta
    {
        [Key]
        public int IdConsulta { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string MedicoCabecera { get; set; }

        public string PacienteConsulta { get; set; }
        public string TipoSangre { get; set; }
        public string EmergenciaLlamar { get; set; }
        public string QuejaPrincipal { get; set; }
        public string PresionArterial { get; set; }
        public string Pulso { get; set; }
        public string FrecuenciaRespiratoria { get; set; }
        public string Estatura { get; set; }
        public string Peso { get; set; }
        public string Temperatura { get; set; }
        public string AntecedentesAlergicos { get; set; }
        public string AntecedentesQuirurjicos { get; set; }
        public string MedicamentosToma { get; set; }
        public string AntecedentesPatologicos { get; set; }
        public string HistorialDental { get; set; }
        public string TejidosBlandos { get; set; }
        public string ExamenExtraoral { get; set; }
        public string PlanTratamiento { get; set; }


    }
}
