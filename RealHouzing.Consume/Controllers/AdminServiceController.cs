using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.Controllers
{
    public class AdminServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
