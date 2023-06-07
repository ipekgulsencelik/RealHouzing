using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _RentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
