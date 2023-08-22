using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.BlogDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        public IActionResult BlogList()
        {
            var values = _blogService.TGetList();
            return Ok(values);
        }
        
        [HttpDelete("{id}")]
        public IActionResult BlogDelete(int id)
        {
            var values = _blogService.TGetByID(id);
            _blogService.TDelete(values);
        
            return Ok();
        }
        
        [HttpPost]
        public IActionResult AddBlog(AddBlogDTO addBlogDTO)
        {
            Blog blog = new Blog()
            {
                BlogImageURL = addBlogDTO.BlogImageURL,
                Date = DateTime.Parse(DateTime.Now.ToShortDateString()),
                Description = addBlogDTO.Description,
                Title = addBlogDTO.Title,
                Writer = addBlogDTO.Writer,
                WriterImageURL = addBlogDTO.WriterImageURL,
            };
            _blogService.TInsert(blog);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBlog(int id)
        {
            var values = _blogService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateBlog(UpdateBlogDTO updateBlogDTO)
        {
            Blog blog = new Blog()
            {
                BlogID = updateBlogDTO.BlogID,
                BlogImageURL = updateBlogDTO.BlogImageURL,
                Description = updateBlogDTO.Description,
                Title = updateBlogDTO.Title,
                Writer = updateBlogDTO.Writer,
                WriterImageURL = updateBlogDTO.WriterImageURL,
                Date = DateTime.Parse(DateTime.Now.ToShortDateString()),
            };
            _blogService.TUpdate(blog);

            return Ok();
        }
    }
}