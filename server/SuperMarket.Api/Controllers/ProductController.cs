using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Core.Models;
using SuperMarket.Services;

namespace SuperMarket.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get() {
            return _productService.getAll();
        }

        [HttpPost]
        public Product Save([FromBody] Product product)
        {
            return _productService.save(product);
        }       

        [HttpDelete("{id}")]
        public void Detele([FromRoute] int id)
        {
            _productService.delete(id);
        } 

        [HttpPut("{id}")]
        public void Update()
        {

        }
    }
}