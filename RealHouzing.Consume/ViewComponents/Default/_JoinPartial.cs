using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _JoinPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
