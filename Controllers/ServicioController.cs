using ClinicaDental01.Data;
using ClinicaDental01.Models;
using ClinicaDental01.Models.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ClinicaDental01.Controllers
{
   
    public class ServicioController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ServicioController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Servicios()
        {
            var Servicio = await applicationDbContext.Servicios.ToListAsync();
            return View(Servicio);
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult CrearServicio()
        {
            return View();
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CrearServicio(CrearServicioViewModel crearServicioRequest)
        {
            var Servicio = new Servicio()
            {
                IdServicio = crearServicioRequest.IdServicio,
                NombreServicio = crearServicioRequest.NombreServicio,
                DescripcionServicio = crearServicioRequest.DescripcionServicio,
                CostoServicio = crearServicioRequest.CostoServicio
            };

            await applicationDbContext.Servicios.AddAsync(Servicio);
            await applicationDbContext.SaveChangesAsync();
            return RedirectToAction("Servicios");
        }

        [HttpGet]


        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> UpdateServicio(int id)
        {
            var Servicio = await applicationDbContext.Servicios.FirstOrDefaultAsync(x => x.IdServicio == id);

            if (Servicio != null)
            {
                var viewModel = new UpdateServicioViewModel()
                {
                    IdServicio = Servicio.IdServicio,
                    NombreServicio = Servicio.NombreServicio,
                    DescripcionServicio = Servicio.DescripcionServicio,
                    CostoServicio = Servicio.CostoServicio
                };
                return await Task.Run(() => View("UpdateServicio", viewModel));
            }
            return RedirectToAction("Servicios");
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> UpdateServicio(UpdateServicioViewModel model)
        {
            var Servicio = await applicationDbContext.Servicios.FindAsync(model.IdServicio);

            if (Servicio != null)
            {
                Servicio.NombreServicio = model.NombreServicio;
                Servicio.DescripcionServicio = model.DescripcionServicio;
                Servicio.CostoServicio = model.CostoServicio;

                await applicationDbContext.SaveChangesAsync();

                return RedirectToAction("Servicios");
            }
            return RedirectToAction("Servicios");
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> EliminarServicio(UpdateServicioViewModel model)
        {
            var Servicio = await applicationDbContext.Servicios.FindAsync(model.IdServicio);
            if (Servicio != null)
            {
                applicationDbContext.Servicios.Remove(Servicio);
                await applicationDbContext.SaveChangesAsync();

                return RedirectToAction("Servicios");
            }

            return RedirectToAction("Servicios");
        }



    }
}
