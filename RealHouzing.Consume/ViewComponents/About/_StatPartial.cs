using Microsoft.AspNetCore.Mvc;
using RealHouzing.DataAccessLayer.Concrete;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _StatPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var context = new Context();

            ViewBag.service = context.Services.Count();
            ViewBag.sale = context.Products.Where(x => x.ProductType == "Satılık").Count();
            ViewBag.rent = context.Products.Where(x => x.ProductType == "Kiralık").Count();
            ViewBag.testimonial = context.Testimonials.Count();

            return View();
        }
    }
}
