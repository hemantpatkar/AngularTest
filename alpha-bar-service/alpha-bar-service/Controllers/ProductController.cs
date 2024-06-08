using alpha_bar_service.Models;
using alpha_bar_service.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alpha_bar_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService productService;
        public ProductController(IProductService _productService)
        {
            this.productService = _productService;
        }



        [HttpGet]
        public ActionResult Get(int ID)
        {
            return base.Ok( this.productService.GetProductDetails(ID).Result);
        }
    }
}
