using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.MapDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        private readonly IMapService _mapService;

        public MapController(IMapService mapService)
        {
            _mapService = mapService;
        }

        [HttpGet]
        public IActionResult MapList()
        {
            var values = _mapService.TGetList();
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMap(int id)
        {
            var value = _mapService.TGetByID(id);
            _mapService.TDelete(value);

            return Ok();
        }

        [HttpPost]
        public IActionResult AddMap(AddMapDTO addMapDTO)
        {
            Map map = new Map()
            {
                MapLocation = addMapDTO.MapLocation,
                Status = addMapDTO.Status,
            };
            _mapService.TInsert(map);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateMap(UpdateMapDTO updateMapDTO)
        {
            Map map = new Map()
            {
                MapID = updateMapDTO.MapID,
                MapLocation = updateMapDTO.MapLocation,
                Status = updateMapDTO.Status,
            };
            _mapService.TUpdate(map);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetMap(int id)
        {
            var values = _mapService.TGetByID(id);
            return Ok(values);
        }
    }
}