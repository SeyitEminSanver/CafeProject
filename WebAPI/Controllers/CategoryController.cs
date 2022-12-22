using Business.Abstract;
using Entities.Concrete.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
           _categoryService = categoryService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if(result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            var result=_categoryService.Add(category);
            if(result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
