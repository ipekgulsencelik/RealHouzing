using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.VideoDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private readonly IVideoService _videoService;

        public VideoController(IVideoService videoService)
        {
            _videoService = videoService;
        }

        [HttpGet]
        public IActionResult ListVideo()
        {
            var values = _videoService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddVideo(AddVideoDTO addVideoDTO)
        {
            Video video = new Video()
            {
                Title = addVideoDTO.Title,
                Description = addVideoDTO.Description,
                VideoURL = addVideoDTO.VideoURL,
            };
            _videoService.TInsert(video);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateVideo(UpdateVideoDTO updateVideoDTO)
        {
            Video video = new Video()
            {
                VideoID = updateVideoDTO.VideoID,
                Title = updateVideoDTO.Title,
                Description = updateVideoDTO.Description,
                VideoURL = updateVideoDTO.VideoURL,

            };
            _videoService.TUpdate(video);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVideo(int id)
        {
            var values = _videoService.TGetByID(id);
            _videoService.TDelete(values);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetVideo(int id)
        {
            var values = _videoService.TGetByID(id);
            return Ok(values);
        }
    }
}
