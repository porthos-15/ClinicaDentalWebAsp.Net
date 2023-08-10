using ClinicaDental01.Data;
using ClinicaDental01.Models;
using ClinicaDental01.Models.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ClinicaDental01.Controllers
{

    public class CitaController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CitaController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Citas()
        {
            var Cita = await applicationDbContext.Citas.ToListAsync();
            return View(Cita);
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult CrearCita()
        {
            return View();
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CrearCita(CrearCitaViewModel crearCitaRequest)
        {
            var Cita = new Cita()
            {
                IdCita = crearCitaRequest.IdCita,
                FechaCita = crearCitaRequest.FechaCita,
                DescripcionCita = crearCitaRequest.DescripcionCita
            };

            await applicationDbContext.Citas.AddAsync(Cita);
            await applicationDbContext.SaveChangesAsync();
            return RedirectToAction("Citas");
        }

        [HttpGet]


        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> UpdateCita(int id)
        {
            var Cita = await applicationDbContext.Citas.FirstOrDefaultAsync(x => x.IdCita == id);

            if (Cita != null)
            {
                var viewModel = new UpdateCitaViewModel()
                {
                    IdCita = Cita.IdCita,
                    FechaCita = Cita.FechaCita,
                    DescripcionCita = Cita.DescripcionCita

                };
                return await Task.Run(() => View("UpdateCita", viewModel));
            }
            return RedirectToAction("Citas");
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> UpdateCita(UpdateCitaViewModel model)
        {
            var Cita = await applicationDbContext.Citas.FindAsync(model.IdCita);

            if (Cita != null)
            {
                Cita.FechaCita = model.FechaCita;
                Cita.DescripcionCita = model.DescripcionCita;


                await applicationDbContext.SaveChangesAsync();

                return RedirectToAction("Citas");
            }
            return RedirectToAction("Citas");
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> EliminarCita(UpdateCitaViewModel model)
        {
            var Cita = await applicationDbContext.Citas.FindAsync(model.IdCita);
            if (Cita != null)
            {
                applicationDbContext.Citas.Remove(Cita);
                await applicationDbContext.SaveChangesAsync();

                return RedirectToAction("Citas");
            }

            return RedirectToAction("Citas");
        }



    }
}
