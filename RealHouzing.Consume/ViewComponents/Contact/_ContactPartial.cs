using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Contact
{
    public class _ContactPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
