using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
