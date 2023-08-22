using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.SubscribeDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult AddSubscribe(AddSubscribeDTO addSubscribeDTO)
        {
            Subscribe subscribe = new Subscribe()
            {
                Mail = addSubscribeDTO.Mail
            };
            _subscribeService.TInsert(subscribe);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(UpdateSubscribeDTO updateSubscribeDTO)
        {
            Subscribe subscribe = new Subscribe()
            {
                Mail = updateSubscribeDTO.Mail,
                SubscribeID = updateSubscribeDTO.SubscribeID
            };
            _subscribeService.TUpdate(subscribe);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            _subscribeService.TDelete(values);
            
            return Ok();
        }
    }
}