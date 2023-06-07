using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
