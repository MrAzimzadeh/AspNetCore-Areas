using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Areas.Areas.Fatura_Paneli.Controllers
{
    [Area(nameof(Fatura_Paneli))]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = TempData["Data"];
            return View();
        }
    }
}
