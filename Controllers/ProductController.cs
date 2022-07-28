using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlusAPI.Model;
using PlusAPI.Services;

namespace PlusAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase {

        ProductService productService;

        public ProductController(ProductService productService) {

            this.productService = productService;
        }

        [HttpGet]
        public ActionResult Get() {

            return Ok(productService.GetProducts());
        }

        [HttpPost]
        public ActionResult Post(Product product) {

            productService.AddProduct(product);
            return Ok();
        }
    }
}