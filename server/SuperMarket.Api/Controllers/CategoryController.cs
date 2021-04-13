using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Core.Models;
using SuperMarket.Services;

namespace SuperMarket.Api.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {

        private ICategoryService _categorySerivce;

        public CategoryController(ICategoryService categorySerivce)
        {
            _categorySerivce = categorySerivce;
        }

        [HttpGet]
        public List<Category> Get()
        {
            return _categorySerivce.getAll();
        }

        [HttpPost]
        public Category Post([FromBody] Category category) 
        {
            return _categorySerivce.Save(category);
        }
    }   
}