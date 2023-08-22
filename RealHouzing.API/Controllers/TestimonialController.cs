using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.TestimonialDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult ListTestimonial()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddTestimonial(AddTestimonialDTO addTestimonialDTO)
        {
            Testimonial testimonial = new Testimonial()
            {
                Comment = addTestimonialDTO.Comment,
                ImageURL = addTestimonialDTO.ImageURL,
                FullName = addTestimonialDTO.FullName,
                Title = addTestimonialDTO.Title,

            };
            _testimonialService.TInsert(testimonial);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var values = _testimonialService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDTO updateTestimonialDTO)
        {
            Testimonial testimonial = new Testimonial()
            {
                TestimonialID = updateTestimonialDTO.TestimonialID,
                Comment = updateTestimonialDTO.Comment,
                ImageURL = updateTestimonialDTO.ImageURL,
                FullName = updateTestimonialDTO.FullName,
                Title = updateTestimonialDTO.Title,
            };
            _testimonialService.TUpdate(testimonial);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(values);

            return Ok();
        }
    }
}