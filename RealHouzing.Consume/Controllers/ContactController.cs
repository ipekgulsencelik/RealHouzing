using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
