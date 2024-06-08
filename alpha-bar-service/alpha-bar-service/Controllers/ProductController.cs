using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alpha_bar_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController() { }


        public ActionResult Index() { }

        public ActionResult Details() { 
        
        
        
        }
        public ActionResult Contact() { }
        public ActionResult Error() { }
        public ActionResult Error(string message) { }

    }
}
