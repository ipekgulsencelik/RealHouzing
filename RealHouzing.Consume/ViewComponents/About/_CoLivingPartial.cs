using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _CoLivingPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
