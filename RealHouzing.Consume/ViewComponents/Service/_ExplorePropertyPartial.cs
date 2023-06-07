using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Service
{
    public class _ExplorePropertyPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
