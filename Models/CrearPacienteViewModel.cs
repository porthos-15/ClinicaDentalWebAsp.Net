using System.ComponentModel.DataAnnotations;

namespace ClinicaDental01.Models
{
    public class CrearPacienteViewModel
    {

        public int IdPaciente { get; set; }
        public int CedulaPaciente { get; set; }

        public string NombrePaciente { get; set; }

        public string PrimerApellidoPaciente { get; set; }

        public string SegundoApellidoPaciente { get; set; }

        [Required]
        public string CorreoPaciente { get; set; }

        public string TelefonoPaciente { get; set; }

        public DateTime FechaNacimientoPaciente { get; set; }

        public string DireccionPaciente { get; set; }
        public string EstadoCivilPaciente { get; set; }

        public string Sexo { get; set; }

        public bool SuccionDeDedo { get; set; }
        public bool ChuponOChupeta { get; set; }
        public bool DuermeConBocaAbiertaOCerrada { get; set; }
        public bool ComeMuerdeObjetos { get; set; }
        public bool ApoyalaManoSobreLaBarbilla { get; set; }
        public bool RastrillaLosDientes { get; set; }

        public bool EnfermedadesCardiacas { get; set; }
        public bool ProblemasDeLaPresionArterial { get; set; }
        public bool DiabetesTipo1 { get; set; }
        public bool DiabetesTipo2 { get; set; }
        public bool FiebreReumAtica { get; set; }
        public bool VIHOSIDA { get; set; }
        public bool ProblemasEnLosRinones { get; set; }
        public bool ProblemasDeVision { get; set; }
        public bool ProblemasDeMareos { get; set; }
        public bool ProblemasDeLaTiroides { get; set; }
        public bool ProblemasGastrointestinales { get; set; }
        public bool Alergia { get; set; }
        public bool EnfermedadDeTransmisionSexual { get; set; }
        public bool Osteoporosis { get; set; }
        public bool DueleAlAbrirOCerrarLaBoca { get; set; }
        public bool Fuma { get; set; }
        public bool TomaLicor { get; set; }
        public bool TratamientoAnticonceptivo { get; set; }
        public bool EstaOcreeEstarEmbarazada { get; set; }
        public bool TratamientoPsiquiatrico { get; set; }
        public bool VirusDelHerpes { get; set; }
        public bool EpilepsiaDesmayoConvulsiones { get; set; }
        public bool AparicionDeEquimosisOMoretes { get; set; }
        public bool EnfermedadesRespiratorias { get; set; }
        public bool ShockAnafilactico { get; set; }
        public bool Hepatitis { get; set; }
        public bool SacaLaLenguaOTieneLenguaProtractil { get; set; }
    }
}
