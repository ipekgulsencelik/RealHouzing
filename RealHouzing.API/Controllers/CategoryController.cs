using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.CategoryDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult ListCategory() 
        {
            var values = _categoryService.TGetList();
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddCategory(ResultCategoryDTO resultCategoryDTO)
        {
            Category category = new Category()
            {
                CategoryName = resultCategoryDTO.CategoryName
            };
            _categoryService.TInsert(category);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDTO updateCategoryDTO)
        {
            Category category = new Category()
            {
                CategoryID = updateCategoryDTO.CategoryID,
                CategoryName = updateCategoryDTO.CategoryName
            };
            _categoryService.TUpdate(category);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var values = _categoryService.TGetByID(id);
            return Ok(values);
        }
    }
}
