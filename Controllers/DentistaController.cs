using Microsoft.AspNetCore.Mvc;

namespace ClinicaDental01.Controllers
{
    public class DentistaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
