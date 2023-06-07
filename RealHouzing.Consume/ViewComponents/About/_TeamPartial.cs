using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _TeamPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
