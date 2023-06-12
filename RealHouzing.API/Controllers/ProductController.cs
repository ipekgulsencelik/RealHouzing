using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.ProductDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult ListProduct()
        {
            var values = _productService.TGetList();
            return Ok(values);
        }

        [HttpGet("GetProductsWithCategories")]
        public IActionResult GetProductsWithCategories()
        {
            var values = _productService.TGetProductsWithCategories();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddProduct(AddProductDTO addProductDTO)
        {
            Product product = new Product()
            {
                BathCount = addProductDTO.BathCount,
                BedRoomCount = addProductDTO.BedRoomCount,
                CategoryID = addProductDTO.CategoryID,
                CoverImageURL = addProductDTO.CoverImageURL,
                ProductAddress = addProductDTO.ProductAddress,
                ProductPrice = addProductDTO.ProductPrice,
                ProductTitle = addProductDTO.ProductTitle,
                ProductType = addProductDTO.ProductType,
                Square = addProductDTO.Square
            };
            _productService.TInsert(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var values = _productService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDTO updateProductDTO)
        {
            Product product = new Product()
            {
                BathCount = updateProductDTO.BathCount,
                BedRoomCount = updateProductDTO.BedRoomCount,
                CategoryID = updateProductDTO.CategoryID,
                CoverImageURL = updateProductDTO.CoverImageURL,
                ProductAddress = updateProductDTO.ProductAddress,
                ProductID = updateProductDTO.ProductID,
                ProductPrice = updateProductDTO.ProductPrice,
                ProductTitle = updateProductDTO.ProductTitle,
                ProductType = updateProductDTO.ProductType,
                Square = updateProductDTO.Square
            };
            _productService.TUpdate(product);
            return Ok();
        }
    }
}