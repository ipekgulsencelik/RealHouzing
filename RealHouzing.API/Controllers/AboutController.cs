using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.AboutDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAbout(AddAboutDTO addAboutDTO)
        {
            About about = new About()
            {
                Title = addAboutDTO.Title,
                Description = addAboutDTO.Description,
                ImageURL = addAboutDTO.ImageURL,
                Item = addAboutDTO.Item,
            };
            _aboutService.TInsert(about);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _aboutService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDTO updateAboutDTO)
        {
            About about = new About()
            {
                AboutID = updateAboutDTO.AboutID,
                Title = updateAboutDTO.Title,
                Description = updateAboutDTO.Description,
                ImageURL = updateAboutDTO.ImageURL,
                Item = updateAboutDTO.Item,
            };
            _aboutService.TUpdate(about);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetByID(id);
            _aboutService.TDelete(values);

            return Ok();
        }
    }
}