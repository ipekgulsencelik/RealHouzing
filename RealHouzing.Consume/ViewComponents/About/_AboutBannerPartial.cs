﻿using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _AboutBannerPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
