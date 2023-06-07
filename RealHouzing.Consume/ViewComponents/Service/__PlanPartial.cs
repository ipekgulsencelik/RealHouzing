using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Service
{
    public class _PlanPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
