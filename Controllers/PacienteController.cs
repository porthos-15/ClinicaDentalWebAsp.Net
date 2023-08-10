using ClinicaDental01.Data;
using ClinicaDental01.Models;
using ClinicaDental01.Models.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicaDental01.Controllers
{

    [Authorize(Roles = "Administrator")]
    public class PacienteController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public PacienteController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Pacientes()
        {
            var paciente = await applicationDbContext.Pacientes.ToListAsync();
            return View(paciente);
        }


        [HttpGet]
        public IActionResult CrearPaciente()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearPaciente(CrearPacienteViewModel crearPacienteRequest)
        {
            var paciente = new Paciente()
            {
                IdPaciente = crearPacienteRequest.IdPaciente,
                CedulaPaciente = crearPacienteRequest.CedulaPaciente,
                NombrePaciente = crearPacienteRequest.NombrePaciente,
                PrimerApellidoPaciente = crearPacienteRequest.PrimerApellidoPaciente,
                SegundoApellidoPaciente = crearPacienteRequest.SegundoApellidoPaciente,
                CorreoPaciente = crearPacienteRequest.CorreoPaciente,
                TelefonoPaciente = crearPacienteRequest.TelefonoPaciente,
                FechaNacimientoPaciente = crearPacienteRequest.FechaNacimientoPaciente,
                DireccionPaciente = crearPacienteRequest.DireccionPaciente,
                EstadoCivilPaciente = crearPacienteRequest.EstadoCivilPaciente,
                Sexo = crearPacienteRequest.Sexo,
                EnfermedadesCardiacas = crearPacienteRequest.EnfermedadesCardiacas,
                ProblemasDeLaPresionArterial = crearPacienteRequest.ProblemasDeLaPresionArterial,
                DiabetesTipo1 = crearPacienteRequest.DiabetesTipo1,
                DiabetesTipo2 = crearPacienteRequest.DiabetesTipo2,
                FiebreReumAtica = crearPacienteRequest.FiebreReumAtica,
                VIHOSIDA = crearPacienteRequest.VIHOSIDA,
                ProblemasEnLosRinones = crearPacienteRequest.ProblemasEnLosRinones,
                ProblemasDeVision = crearPacienteRequest.ProblemasDeVision,
                ProblemasDeMareos = crearPacienteRequest.ProblemasDeMareos,
                ProblemasDeLaTiroides = crearPacienteRequest.ProblemasDeLaTiroides,
                ProblemasGastrointestinales = crearPacienteRequest.ProblemasGastrointestinales,
                Alergia = crearPacienteRequest.Alergia,
                EnfermedadDeTransmisionSexual = crearPacienteRequest.EnfermedadDeTransmisionSexual,
                Osteoporosis = crearPacienteRequest.Osteoporosis,
                DueleAlAbrirOCerrarLaBoca = crearPacienteRequest.DueleAlAbrirOCerrarLaBoca,
                Fuma = crearPacienteRequest.Fuma,
                TomaLicor = crearPacienteRequest.TomaLicor,
                TratamientoAnticonceptivo = crearPacienteRequest.TratamientoAnticonceptivo,
                EstaOcreeEstarEmbarazada = crearPacienteRequest.EstaOcreeEstarEmbarazada,
                TratamientoPsiquiatrico = crearPacienteRequest.TratamientoPsiquiatrico,
                VirusDelHerpes = crearPacienteRequest.VirusDelHerpes,
                EpilepsiaDesmayoConvulsiones = crearPacienteRequest.EpilepsiaDesmayoConvulsiones,
                AparicionDeEquimosisOMoretes = crearPacienteRequest.AparicionDeEquimosisOMoretes,
                EnfermedadesRespiratorias = crearPacienteRequest.EnfermedadesRespiratorias,
                ShockAnafilactico = crearPacienteRequest.ShockAnafilactico,
                Hepatitis = crearPacienteRequest.Hepatitis,
                SacaLaLenguaOTieneLenguaProtractil = crearPacienteRequest.SacaLaLenguaOTieneLenguaProtractil,
                SuccionDeDedo = crearPacienteRequest.SuccionDeDedo,
                ChuponOChupeta = crearPacienteRequest.ChuponOChupeta,
                DuermeConBocaAbiertaOCerrada = crearPacienteRequest.DuermeConBocaAbiertaOCerrada,
                ComeMuerdeObjetos = crearPacienteRequest.ComeMuerdeObjetos,
                ApoyalaManoSobreLaBarbilla = crearPacienteRequest.ApoyalaManoSobreLaBarbilla,
                RastrillaLosDientes = crearPacienteRequest.RastrillaLosDientes

            };

            await applicationDbContext.Pacientes.AddAsync(paciente);
            await applicationDbContext.SaveChangesAsync();
            return RedirectToAction("Pacientes");
        }

        [HttpGet]



        [HttpGet]
        public async Task<IActionResult> UpdatePaciente(int id)
        {
            var paciente = await applicationDbContext.Pacientes.FirstOrDefaultAsync(x => x.IdPaciente == id);

            if (paciente != null)
            {
                var viewModel = new UpdatePacienteViewModel()
                {
                    IdPaciente = paciente.IdPaciente,
                    CedulaPaciente = paciente.CedulaPaciente,
                    NombrePaciente = paciente.NombrePaciente,
                    PrimerApellidoPaciente = paciente.PrimerApellidoPaciente,
                    SegundoApellidoPaciente = paciente.SegundoApellidoPaciente,
                    CorreoPaciente = paciente.CorreoPaciente,
                    TelefonoPaciente = paciente.TelefonoPaciente,
                    FechaNacimientoPaciente = paciente.FechaNacimientoPaciente,
                    DireccionPaciente = paciente.DireccionPaciente,
                    EstadoCivilPaciente = paciente.EstadoCivilPaciente,
                    Sexo = paciente.Sexo,
                    EnfermedadesCardiacas = paciente.EnfermedadesCardiacas,
                    ProblemasDeLaPresionArterial = paciente.ProblemasDeLaPresionArterial,
                    DiabetesTipo1 = paciente.DiabetesTipo1,
                    DiabetesTipo2 = paciente.DiabetesTipo2,
                    FiebreReumAtica = paciente.FiebreReumAtica,
                    VIHOSIDA = paciente.VIHOSIDA,
                    ProblemasEnLosRinones = paciente.ProblemasEnLosRinones,
                    ProblemasDeVision = paciente.ProblemasDeVision,
                    ProblemasDeMareos = paciente.ProblemasDeMareos,
                    ProblemasDeLaTiroides = paciente.ProblemasDeLaTiroides,
                    ProblemasGastrointestinales = paciente.ProblemasGastrointestinales,
                    Alergia = paciente.Alergia,
                    EnfermedadDeTransmisionSexual = paciente.EnfermedadDeTransmisionSexual,
                    Osteoporosis = paciente.Osteoporosis,
                    DueleAlAbrirOCerrarLaBoca = paciente.DueleAlAbrirOCerrarLaBoca,
                    Fuma = paciente.Fuma,
                    TomaLicor = paciente.TomaLicor,
                    TratamientoAnticonceptivo = paciente.TratamientoAnticonceptivo,
                    EstaOcreeEstarEmbarazada = paciente.EstaOcreeEstarEmbarazada,
                    TratamientoPsiquiatrico = paciente.TratamientoPsiquiatrico,
                    VirusDelHerpes = paciente.VirusDelHerpes,
                    EpilepsiaDesmayoConvulsiones = paciente.EpilepsiaDesmayoConvulsiones,
                    AparicionDeEquimosisOMoretes = paciente.AparicionDeEquimosisOMoretes,
                    EnfermedadesRespiratorias = paciente.EnfermedadesRespiratorias,
                    ShockAnafilactico = paciente.ShockAnafilactico,
                    Hepatitis = paciente.Hepatitis,
                    SacaLaLenguaOTieneLenguaProtractil = paciente.SacaLaLenguaOTieneLenguaProtractil,
                    SuccionDeDedo = paciente.SuccionDeDedo,
                    ChuponOChupeta = paciente.ChuponOChupeta,
                    DuermeConBocaAbiertaOCerrada = paciente.DuermeConBocaAbiertaOCerrada,
                    ComeMuerdeObjetos = paciente.ComeMuerdeObjetos,
                    ApoyalaManoSobreLaBarbilla = paciente.ApoyalaManoSobreLaBarbilla,
                    RastrillaLosDientes = paciente.RastrillaLosDientes

                };
                return await Task.Run(() => View("UpdatePaciente", viewModel));
            }
            return RedirectToAction("Pacientes");
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePaciente(UpdatePacienteViewModel model)
        {
            var paciente = await applicationDbContext.Pacientes.FindAsync(model.IdPaciente);

            if (paciente != null)
            {
                paciente.CedulaPaciente = model.CedulaPaciente;
                paciente.NombrePaciente = model.NombrePaciente;
                paciente.PrimerApellidoPaciente = model.PrimerApellidoPaciente;
                paciente.SegundoApellidoPaciente = model.SegundoApellidoPaciente;
                paciente.CorreoPaciente = model.CorreoPaciente;
                paciente.TelefonoPaciente = model.TelefonoPaciente;
                paciente.DireccionPaciente = model.DireccionPaciente;
                paciente.FechaNacimientoPaciente = model.FechaNacimientoPaciente;
                paciente.EstadoCivilPaciente = model.EstadoCivilPaciente;
                paciente.Sexo = model.Sexo;
                paciente.EnfermedadesCardiacas = model.EnfermedadesCardiacas;
                paciente.ProblemasDeLaPresionArterial = model.ProblemasDeLaPresionArterial;
                paciente.DiabetesTipo1 = model.DiabetesTipo1;
                paciente.DiabetesTipo2 = model.DiabetesTipo2;
                paciente.FiebreReumAtica = model.FiebreReumAtica;
                paciente.VIHOSIDA = model.VIHOSIDA;
                paciente.ProblemasEnLosRinones = model.ProblemasEnLosRinones;
                paciente.ProblemasDeVision = model.ProblemasDeVision;
                paciente.ProblemasDeMareos = model.ProblemasDeMareos;
                paciente.ProblemasDeLaTiroides = model.ProblemasDeLaTiroides;
                paciente.ProblemasGastrointestinales = model.ProblemasGastrointestinales;
                paciente.Alergia = model.Alergia;
                paciente.EnfermedadDeTransmisionSexual = model.EnfermedadDeTransmisionSexual;
                paciente.Osteoporosis = model.Osteoporosis;
                paciente.DueleAlAbrirOCerrarLaBoca = model.DueleAlAbrirOCerrarLaBoca;
                paciente.Fuma = model.Fuma;
                paciente.TomaLicor = model.TomaLicor;
                paciente.TratamientoAnticonceptivo = model.TratamientoAnticonceptivo;
                paciente.EstaOcreeEstarEmbarazada = model.EstaOcreeEstarEmbarazada;
                paciente.TratamientoPsiquiatrico = model.TratamientoPsiquiatrico;
                paciente.VirusDelHerpes = model.VirusDelHerpes;
                paciente.EpilepsiaDesmayoConvulsiones = model.EpilepsiaDesmayoConvulsiones;
                paciente.AparicionDeEquimosisOMoretes = model.AparicionDeEquimosisOMoretes;
                paciente.EnfermedadesRespiratorias = model.EnfermedadesRespiratorias;
                paciente.ShockAnafilactico = model.ShockAnafilactico;
                paciente.Hepatitis = model.Hepatitis;
                paciente.SacaLaLenguaOTieneLenguaProtractil = model.SacaLaLenguaOTieneLenguaProtractil;
                paciente.SuccionDeDedo = model.SuccionDeDedo;
                paciente.ChuponOChupeta = model.ChuponOChupeta;
                paciente.DuermeConBocaAbiertaOCerrada = model.DuermeConBocaAbiertaOCerrada;
                paciente.ComeMuerdeObjetos = model.ComeMuerdeObjetos;
                paciente.ApoyalaManoSobreLaBarbilla = model.ApoyalaManoSobreLaBarbilla;
                paciente.RastrillaLosDientes = model.RastrillaLosDientes;


                await applicationDbContext.SaveChangesAsync();

                return RedirectToAction("Pacientes");
            }
            return RedirectToAction("Pacientes");
        }

        [HttpPost]
        public async Task<IActionResult> EliminarPaciente(UpdatePacienteViewModel model)
        {
            var paciente = await applicationDbContext.Pacientes.FindAsync(model.IdPaciente);
            if (paciente != null)
            {
                applicationDbContext.Pacientes.Remove(paciente);
                await applicationDbContext.SaveChangesAsync();

                return RedirectToAction("Pacientes");
            }

            return RedirectToAction("Pacientes");
        }



        //ver historial

        [HttpGet]
        public async Task<IActionResult> VerHistorial(int id)
        {
            var paciente = await applicationDbContext.Pacientes.FirstOrDefaultAsync(x => x.IdPaciente == id);

            if (paciente != null)
            {
                var viewModel = new UpdatePacienteViewModel()
                {

                    EnfermedadesCardiacas = paciente.EnfermedadesCardiacas,
                    ProblemasDeLaPresionArterial = paciente.ProblemasDeLaPresionArterial,
                    DiabetesTipo1 = paciente.DiabetesTipo1,
                    DiabetesTipo2 = paciente.DiabetesTipo2,
                    FiebreReumAtica = paciente.FiebreReumAtica,
                    VIHOSIDA = paciente.VIHOSIDA,
                    ProblemasEnLosRinones = paciente.ProblemasEnLosRinones,
                    ProblemasDeVision = paciente.ProblemasDeVision,
                    ProblemasDeMareos = paciente.ProblemasDeMareos,
                    ProblemasDeLaTiroides = paciente.ProblemasDeLaTiroides,
                    ProblemasGastrointestinales = paciente.ProblemasGastrointestinales,
                    Alergia = paciente.Alergia,
                    EnfermedadDeTransmisionSexual = paciente.EnfermedadDeTransmisionSexual,
                    Osteoporosis = paciente.Osteoporosis,
                    DueleAlAbrirOCerrarLaBoca = paciente.DueleAlAbrirOCerrarLaBoca,
                    Fuma = paciente.Fuma,
                    TomaLicor = paciente.TomaLicor,
                    TratamientoAnticonceptivo = paciente.TratamientoAnticonceptivo,
                    EstaOcreeEstarEmbarazada = paciente.EstaOcreeEstarEmbarazada,
                    TratamientoPsiquiatrico = paciente.TratamientoPsiquiatrico,
                    VirusDelHerpes = paciente.VirusDelHerpes,
                    EpilepsiaDesmayoConvulsiones = paciente.EpilepsiaDesmayoConvulsiones,
                    AparicionDeEquimosisOMoretes = paciente.AparicionDeEquimosisOMoretes,
                    EnfermedadesRespiratorias = paciente.EnfermedadesRespiratorias,
                    ShockAnafilactico = paciente.ShockAnafilactico,
                    Hepatitis = paciente.Hepatitis,
                    SacaLaLenguaOTieneLenguaProtractil = paciente.SacaLaLenguaOTieneLenguaProtractil,
                    SuccionDeDedo = paciente.SuccionDeDedo,
                    ChuponOChupeta = paciente.ChuponOChupeta,
                    DuermeConBocaAbiertaOCerrada = paciente.DuermeConBocaAbiertaOCerrada,
                    ComeMuerdeObjetos = paciente.ComeMuerdeObjetos,
                    ApoyalaManoSobreLaBarbilla = paciente.ApoyalaManoSobreLaBarbilla,
                    RastrillaLosDientes = paciente.RastrillaLosDientes

                };
                return await Task.Run(() => View("VerHistorial", viewModel));
            }
            return RedirectToAction("Pacientes");
        }

        [HttpPost]
        public async Task<IActionResult> VerHistorial(UpdatePacienteViewModel model)
        {
            var paciente = await applicationDbContext.Pacientes.FindAsync(model.IdPaciente);

            if (paciente != null)
            {
                paciente.EnfermedadesCardiacas = model.EnfermedadesCardiacas;
                paciente.ProblemasDeLaPresionArterial = model.ProblemasDeLaPresionArterial;
                paciente.DiabetesTipo1 = model.DiabetesTipo1;
                paciente.DiabetesTipo2 = model.DiabetesTipo2;
                paciente.FiebreReumAtica = model.FiebreReumAtica;
                paciente.VIHOSIDA = model.VIHOSIDA;
                paciente.ProblemasEnLosRinones = model.ProblemasEnLosRinones;
                paciente.ProblemasDeVision = model.ProblemasDeVision;
                paciente.ProblemasDeMareos = model.ProblemasDeMareos;
                paciente.ProblemasDeLaTiroides = model.ProblemasDeLaTiroides;
                paciente.ProblemasGastrointestinales = model.ProblemasGastrointestinales;
                paciente.Alergia = model.Alergia;
                paciente.EnfermedadDeTransmisionSexual = model.EnfermedadDeTransmisionSexual;
                paciente.Osteoporosis = model.Osteoporosis;
                paciente.DueleAlAbrirOCerrarLaBoca = model.DueleAlAbrirOCerrarLaBoca;
                paciente.Fuma = model.Fuma;
                paciente.TomaLicor = model.TomaLicor;
                paciente.TratamientoAnticonceptivo = model.TratamientoAnticonceptivo;
                paciente.EstaOcreeEstarEmbarazada = model.EstaOcreeEstarEmbarazada;
                paciente.TratamientoPsiquiatrico = model.TratamientoPsiquiatrico;
                paciente.VirusDelHerpes = model.VirusDelHerpes;
                paciente.EpilepsiaDesmayoConvulsiones = model.EpilepsiaDesmayoConvulsiones;
                paciente.AparicionDeEquimosisOMoretes = model.AparicionDeEquimosisOMoretes;
                paciente.EnfermedadesRespiratorias = model.EnfermedadesRespiratorias;
                paciente.ShockAnafilactico = model.ShockAnafilactico;
                paciente.Hepatitis = model.Hepatitis;
                paciente.SacaLaLenguaOTieneLenguaProtractil = model.SacaLaLenguaOTieneLenguaProtractil;
                paciente.SuccionDeDedo = model.SuccionDeDedo;
                paciente.ChuponOChupeta = model.ChuponOChupeta;
                paciente.DuermeConBocaAbiertaOCerrada = model.DuermeConBocaAbiertaOCerrada;
                paciente.ComeMuerdeObjetos = model.ComeMuerdeObjetos;
                paciente.ApoyalaManoSobreLaBarbilla = model.ApoyalaManoSobreLaBarbilla;
                paciente.RastrillaLosDientes = model.RastrillaLosDientes;

                return RedirectToAction("Pacientes");
            }
            return RedirectToAction("Pacientes");
        }




    }
}
