using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _BannerPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
