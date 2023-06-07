using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Contact
{
    public class _SubContactPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
