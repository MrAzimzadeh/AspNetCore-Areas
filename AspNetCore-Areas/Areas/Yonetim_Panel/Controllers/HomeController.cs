using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Areas.Areas.Yonetim_Panel.Controllers
{


    [Area(nameof(Yonetim_Panel))]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["Data"] = "Salam bu bir temp data mesajidir ";
            return RedirectToAction("Index", "Home", new { area = "Fatura_Paneli" });
        
        }
    }
}
