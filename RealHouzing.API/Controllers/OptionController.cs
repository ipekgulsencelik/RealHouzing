using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.OptionDTOs;
using RealHouzing.DTOLayer.TeamDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionController : ControllerBase
    {
        private readonly IOptionService _optionService;

        public OptionController(IOptionService optionService)
        {
            _optionService = optionService;
        }

        [HttpGet]
        public IActionResult ListOption()
        {
            var values = _optionService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddOption(AddOptionDTO addOptionDTO)
        {
            Option option = new Option()
            {
                Title = addOptionDTO.Title,
                ImageURL = addOptionDTO.ImageURL,
            };
            _optionService.TInsert(option);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateOption(UpdateOptionDTO updateOptionDTO)
        {
            Option option = new Option()
            {
                OptionID = updateOptionDTO.OptionID,
                Title = updateOptionDTO.Title,
                ImageURL = updateOptionDTO.ImageURL,
            };
            _optionService.TUpdate(option);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOption(int id)
        {
            var values = _optionService.TGetByID(id);
            _optionService.TDelete(values);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetOption(int id)
        {
            var values = _optionService.TGetByID(id);
            return Ok(values);
        }
    }
}
