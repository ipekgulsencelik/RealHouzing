using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewCompanents.Default
{
    public class _ScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
