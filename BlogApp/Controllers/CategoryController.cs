using BlogAppBusiness.DTOs.Category;
using BlogAppBusiness.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(categoryService.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]CreateCategoryDto dto)
        {
            try
            {
                return Ok(await categoryService.Create(dto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] UpdateCategoryDto dto)
        {
            try
            {
                await categoryService.Update(dto);
                return Ok();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}