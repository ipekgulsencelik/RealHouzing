using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
