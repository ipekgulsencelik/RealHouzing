using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.PostPropertyDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostingController : ControllerBase
    {
        private readonly IPostPropertyService _postingService;

        public PostingController(IPostPropertyService postingService)
        {
            _postingService = postingService;
        }

        [HttpGet]
        public IActionResult PostingList()
        {
            var values = _postingService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddPosting(AddPostPropertyDTO addPostPropertyDTO)
        {
            PostProperty posting = new PostProperty()
            {
                Description = addPostPropertyDTO.Description,
                ImageURL = addPostPropertyDTO.ImageURL,
                Title = addPostPropertyDTO.Title,
            };
            _postingService.TInsert(posting);
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePosting(int id)
        {
            var values = _postingService.TGetByID(id);
            _postingService.TDelete(values);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetPosting(int id)
        {
            var values = _postingService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdatePosting(UpdatePostPropertyDTO updatePostPropertyDTO)
        {
            PostProperty posting = new PostProperty()
            {
                PostPropertyID = updatePostPropertyDTO.PostPropertyID,
                Description = updatePostPropertyDTO.Description,
                ImageURL = updatePostPropertyDTO.ImageURL,
                Title = updatePostPropertyDTO.Title,
            };
            _postingService.TUpdate(posting);
            
            return Ok();
        }
    }
}