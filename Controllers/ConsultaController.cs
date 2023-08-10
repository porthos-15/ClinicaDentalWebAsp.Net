using ClinicaDental01.Data;
using ClinicaDental01.Models;
using ClinicaDental01.Models.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ClinicaDental01.Controllers
{

    public class ConsultaController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ConsultaController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Consultas()
        {
            var Consulta = await applicationDbContext.Consultas.ToListAsync();
            return View(Consulta);
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult CrearConsulta()
        {
            return View();
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CrearConsulta(CrearConsultaViewModel crearConsultaRequest)
        {
            var Consulta = new Consulta()
            {
                IdConsulta = crearConsultaRequest.IdConsulta,
                FechaConsulta = crearConsultaRequest.FechaConsulta,
                MedicoCabecera = crearConsultaRequest.MedicoCabecera,
                TipoSangre = crearConsultaRequest.TipoSangre,
                EmergenciaLlamar = crearConsultaRequest.EmergenciaLlamar,
                QuejaPrincipal = crearConsultaRequest.QuejaPrincipal,
                PresionArterial = crearConsultaRequest.PresionArterial,
                Pulso = crearConsultaRequest.Pulso,
                FrecuenciaRespiratoria = crearConsultaRequest.FrecuenciaRespiratoria,
                Estatura = crearConsultaRequest.Estatura,
                Peso = crearConsultaRequest.Peso,
                Temperatura = crearConsultaRequest.Temperatura,
                AntecedentesAlergicos = crearConsultaRequest.AntecedentesAlergicos,
                AntecedentesQuirurjicos = crearConsultaRequest.AntecedentesQuirurjicos,
                MedicamentosToma = crearConsultaRequest.MedicamentosToma,
                AntecedentesPatologicos = crearConsultaRequest.AntecedentesPatologicos,
                HistorialDental = crearConsultaRequest.HistorialDental,
                TejidosBlandos = crearConsultaRequest.TejidosBlandos,
                ExamenExtraoral = crearConsultaRequest.ExamenExtraoral,
                PacienteConsulta = crearConsultaRequest.PacienteConsulta,
                PlanTratamiento = crearConsultaRequest.PlanTratamiento

            };

            await applicationDbContext.Consultas.AddAsync(Consulta);
            await applicationDbContext.SaveChangesAsync();
            return RedirectToAction("Consultas");
        }

        [HttpGet]


        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> UpdateConsulta(int id)
        {
            var Consulta = await applicationDbContext.Consultas.FirstOrDefaultAsync(x => x.IdConsulta == id);

            if (Consulta != null)
            {
                var viewModel = new UpdateConsultaViewModel()
                {
                    IdConsulta = Consulta.IdConsulta,
                    FechaConsulta = Consulta.FechaConsulta,
                    MedicoCabecera = Consulta.MedicoCabecera,
                    TipoSangre = Consulta.TipoSangre,
                    EmergenciaLlamar = Consulta.EmergenciaLlamar,
                    QuejaPrincipal = Consulta.QuejaPrincipal,
                    PresionArterial = Consulta.PresionArterial,
                    Pulso = Consulta.Pulso,
                    FrecuenciaRespiratoria = Consulta.FrecuenciaRespiratoria,
                    Estatura = Consulta.Estatura,
                    Peso = Consulta.Peso,
                    Temperatura = Consulta.Temperatura,
                    AntecedentesAlergicos = Consulta.AntecedentesAlergicos,
                    AntecedentesQuirurjicos = Consulta.AntecedentesQuirurjicos,
                    MedicamentosToma = Consulta.MedicamentosToma,
                    AntecedentesPatologicos = Consulta.AntecedentesPatologicos,
                    HistorialDental = Consulta.HistorialDental,
                    TejidosBlandos = Consulta.TejidosBlandos,
                    ExamenExtraoral = Consulta.ExamenExtraoral,
                    PacienteConsulta = Consulta.PacienteConsulta,
                    PlanTratamiento = Consulta.PlanTratamiento

                };
                return await Task.Run(() => View("UpdateConsulta", viewModel));
            }
            return RedirectToAction("Consultas");
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> UpdateConsulta(UpdateConsultaViewModel model)
        {
            var Consulta = await applicationDbContext.Consultas.FindAsync(model.IdConsulta);

            if (Consulta != null)
            {

                Consulta.FechaConsulta = model.FechaConsulta;
                Consulta.MedicoCabecera = model.MedicoCabecera;
                Consulta.TipoSangre = model.TipoSangre;
                Consulta.EmergenciaLlamar = model.EmergenciaLlamar;
                Consulta.QuejaPrincipal = model.QuejaPrincipal;
                Consulta.PresionArterial = model.PresionArterial;
                Consulta.Pulso = model.Pulso;
                Consulta.FrecuenciaRespiratoria = model.FrecuenciaRespiratoria;
                Consulta.Estatura = model.Estatura;
                Consulta.Peso = model.Peso;
                Consulta.Temperatura = model.Temperatura;
                Consulta.AntecedentesAlergicos = model.AntecedentesAlergicos;
                Consulta.AntecedentesQuirurjicos = model.AntecedentesQuirurjicos;
                Consulta.MedicamentosToma = model.MedicamentosToma;
                Consulta.AntecedentesPatologicos = model.AntecedentesPatologicos;
                Consulta.HistorialDental = model.HistorialDental;
                Consulta.TejidosBlandos = model.TejidosBlandos;
                Consulta.ExamenExtraoral = model.ExamenExtraoral;
                Consulta.PlanTratamiento = model.PlanTratamiento;
                Consulta.PacienteConsulta = model.PacienteConsulta;


                await applicationDbContext.SaveChangesAsync();

                return RedirectToAction("Consultas");
            }
            return RedirectToAction("Consultas");
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> EliminarConsulta(UpdateConsultaViewModel model)
        {
            var Consulta = await applicationDbContext.Consultas.FindAsync(model.IdConsulta);
            if (Consulta != null)
            {
                applicationDbContext.Consultas.Remove(Consulta);
                await applicationDbContext.SaveChangesAsync();

                return RedirectToAction("Consultas");
            }

            return RedirectToAction("Consultas");
        }



    }
}
