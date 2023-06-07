using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _TestimonialPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
