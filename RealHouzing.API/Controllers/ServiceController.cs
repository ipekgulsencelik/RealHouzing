using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.ServiceDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ListService()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddService(AddServiceDTO addServiceDTO)
        {
            Service service = new Service()
            {
                Description = addServiceDTO.Description,
                Icon = addServiceDTO.Icon,
                ServiceName = addServiceDTO.ServiceName,
                Title = addServiceDTO.Title
            };
            _serviceService.TInsert(service);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.TGetByID(id);
            _serviceService.TDelete(values);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _serviceService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateService(UpdateServiceDTO updateServiceDTO)
        {
            Service service = new Service()
            {
                Description = updateServiceDTO.Description,
                Icon = updateServiceDTO.Icon,
                ServiceName = updateServiceDTO.ServiceName,
                Title = updateServiceDTO.Title,
                ServiceID = updateServiceDTO.ServiceID,

            };
            _serviceService.TUpdate(service);

            return Ok();
        }
    }
}