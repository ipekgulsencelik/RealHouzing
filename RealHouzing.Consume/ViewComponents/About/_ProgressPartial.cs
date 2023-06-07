using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _ProgressPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
