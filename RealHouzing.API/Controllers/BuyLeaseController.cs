using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.BuyLeaseDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyLeaseController : ControllerBase
    {
        private readonly IBuyLeaseService _buyLeaseService;

        public BuyLeaseController(IBuyLeaseService buyLeaseService)
        {
            _buyLeaseService = buyLeaseService;
        }

        [HttpGet]
        public IActionResult BuyLeaseList()
        {
            var values = _buyLeaseService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBuyLease(AddBuyLeaseDTO addBuyLeaseDTO)
        {
            BuyLease buyLease = new BuyLease()
            {
                Button = addBuyLeaseDTO.Button,
                ImageURL = addBuyLeaseDTO.ImageURL,
                Title = addBuyLeaseDTO.Title,
                SubTitle = addBuyLeaseDTO.SubTitle,
            };
            _buyLeaseService.TInsert(buyLease);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBuyLease(int id)
        {
            var values = _buyLeaseService.TGetByID(id);
            _buyLeaseService.TDelete(values);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBuyLease(int id)
        {
            var values = _buyLeaseService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateBuyLease(UpdateBuyLeaseDTO updateBuyLeaseDTO)
        {
            BuyLease buyLease = new BuyLease()
            {
                Button = updateBuyLeaseDTO.Button,
                ImageURL = updateBuyLeaseDTO.ImageURL,
                Title = updateBuyLeaseDTO.Title,
                SubTitle = updateBuyLeaseDTO.SubTitle,
                BuyLeaseID = updateBuyLeaseDTO.BuyLeaseID,
            };
            _buyLeaseService.TUpdate(buyLease);
            
            return Ok();
        }
    }
}