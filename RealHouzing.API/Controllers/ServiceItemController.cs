using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.ServiceItemDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceItemController : ControllerBase
    {
        private readonly IServiceItemService _serviceItemService;

        public ServiceItemController(IServiceItemService serviceItemService)
        {
            _serviceItemService = serviceItemService;
        }

        [HttpGet]
        public IActionResult ListServiceItem()
        {
            var values = _serviceItemService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddServiceItem(AddServiceItemDTO addServiceItemDTO)
        {
            ServiceItem serviceItem = new ServiceItem()
            {
                ServiceName = addServiceItemDTO.ServiceName,
                ServiceStatus = addServiceItemDTO.ServiceStatus,
            };
            _serviceItemService.TInsert(serviceItem);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteServiceItem(int id)
        {
            var values = _serviceItemService.TGetByID(id);
            _serviceItemService.TDelete(values);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetServiceItem(int id)
        {
            var values = _serviceItemService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateServiceItem(UpdateServiceItemDTO updateServiceItemDTO)
        {
            ServiceItem serviceItem = new ServiceItem()
            {
                ServiceItemID = updateServiceItemDTO.ServiceItemID,
                ServiceName = updateServiceItemDTO.ServiceName,
                ServiceStatus = updateServiceItemDTO.ServiceStatus,
            };
            _serviceItemService.TUpdate(serviceItem);

            return Ok();
        }
    }
}