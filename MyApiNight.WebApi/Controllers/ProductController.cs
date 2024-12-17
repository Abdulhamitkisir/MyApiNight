using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiNight.BusinessLayer.Abstract;
using MyApiNight.EntityLayer.Concrete;

namespace MyApiNight.WebApi.Controllers
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
        public IActionResult ProductList() 
        {
            var values = _productService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCategory(Product product)
        {
            _productService.TInsert(product);
            return Ok("Ekleme Basarili");
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            _productService.TDelete(id);
            return Ok("Silme Basarili");
        }

        [HttpGet("GetProduct")]
        public IActionResult GetCategory(int id) 
        {
            var values=_productService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateProduct(Product product) 
        {
            _productService.TUpdate(product);
            return Ok("Güncelleme Basarili");
        }
        [HttpGet("ProductCount")]
        public IActionResult ProductCount(int id) 
        {
            return Ok(_productService.TGetProductCount());
        }

    }
}
