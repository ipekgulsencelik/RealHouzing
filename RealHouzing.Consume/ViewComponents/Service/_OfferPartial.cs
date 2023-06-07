using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Service
{
    public class _OfferPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
