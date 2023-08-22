using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.ContactDTOs;
using RealHouzing.DTOLayer.InformationDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactInformationController : ControllerBase
    {
        private readonly IContactInformationService _contactInformationService;

        public ContactInformationController(IContactInformationService contactInformationService)
        {
            _contactInformationService = contactInformationService;
        }

        [HttpGet]
        public IActionResult ContactInformationList()
        {
            var values = _contactInformationService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddContactInformation(AddInfoDTO addInfoDTO)
        {
            ContactInformation information = new ContactInformation()
            {
                Address = addInfoDTO.Address,
                Mail1 = addInfoDTO.Mail1,
                Mail2 = addInfoDTO.Mail2,
                Phone1 = addInfoDTO.Phone1,
                Phone2 = addInfoDTO.Phone2,    
            };
            _contactInformationService.TInsert(information);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var values = _contactInformationService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateInfoDTO updateInfoDTO)
        {
            ContactInformation information = new ContactInformation()
            {
                ContactInformationID = updateInfoDTO.ContactInformationID,
                Address = updateInfoDTO.Address,
                Mail1 = updateInfoDTO.Mail1,
                Mail2 = updateInfoDTO.Mail2,
                Phone1 = updateInfoDTO.Phone1,
                Phone2 = updateInfoDTO.Phone2,
            };
            _contactInformationService.TUpdate(information);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var values = _contactInformationService.TGetByID(id);
            _contactInformationService.TDelete(values);

            return Ok();
        }
    }
}