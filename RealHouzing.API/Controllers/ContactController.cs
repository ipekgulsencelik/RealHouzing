using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.ContactDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddContact(AddContactDTO addContactDTO)
        {
            Contact contact = new Contact()
            {
                Message = addContactDTO.Message,
                Mail = addContactDTO.Mail,
                FullName = addContactDTO.FullName,
                Phone = addContactDTO.Phone,
                Subject = addContactDTO.Subject
            };
            _contactService.TInsert(contact);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var values = _contactService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDTO updateContactDTO)
        {
            Contact contact = new Contact()
            {
                ContactID = updateContactDTO.ContactID,
                Message = updateContactDTO.Message,
                Mail =  updateContactDTO.Mail,
                FullName = updateContactDTO.FullName,
                Phone = updateContactDTO.Phone,
                Subject = updateContactDTO.Subject
            };
            _contactService.TUpdate(contact);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var values = _contactService.TGetByID(id);
            _contactService.TDelete(values);

            return Ok();
        }
    }
}