﻿using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Service
{
    public class _ServiceBannerPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
