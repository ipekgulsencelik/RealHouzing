using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _FooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}