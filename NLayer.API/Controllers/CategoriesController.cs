using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _service;
        public CategoriesController(IMapper mapper, ICategoryService categoryService)
        {

            _mapper = mapper;
            _service = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var categories = await _service.GetAllAsync();
            var categoryDtos = _mapper.Map<List<CategoryDto>>(categories.ToList());
            return CreateActionResult(CustomResponseDto<List<CategoryDto>>.Success(200, categoryDtos));
        }

        //Get /api/category/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var category = await _service.GetByIdAsync(id);
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return CreateActionResult(CustomResponseDto<CategoryDto>.Success(200, categoryDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto categoryDto)
        {
            var category = await _service.AddAsync(_mapper.Map<Category>(categoryDto));
            var categoriesDto = _mapper.Map<CategoryDto>(category);
            return CreateActionResult(CustomResponseDto<CategoryDto>.Success(201, categoriesDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CategoryDto categoryDto)
        {
            await _service.UpdateAsync(_mapper.Map<Category>(categoryDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        //Delete /api/category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var category = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(category);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        //// Get /api/category/GetSingleCategoryByIdWithProductsAsync
        [HttpGet("GetSingleCategoryByIdWithProductsAsync")]
        public async Task<IActionResult> GetSingleCategoryByIdWithProductsAsync(int id)
        {
            return CreateActionResult(await _service.GetSingleCategoryByIdWithProductsAsync(id));
        }



    }
}
