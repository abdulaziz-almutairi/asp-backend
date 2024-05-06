using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.services;
using sdaonsite_2_csharp_backend_teamwork.src.Services;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller
{
    public class CategoryController : CostumeController
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }



        [HttpGet]
        public ActionResult<IEnumerable<Category>> FindAll()
        {
            return Ok(_categoryService.FindAll());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Category> CreateOne([FromBody] CategoryCreateDto category)
        {
            var createdCategory = _categoryService.CreateOne(category);
            return createdCategory;
        }
    }
}