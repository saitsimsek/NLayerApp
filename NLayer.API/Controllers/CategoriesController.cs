using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IProjectService _service;
        public ProjectsController(IMapper mapper, IProjectService ProjectService)
        {

            _mapper = mapper;
            _service = ProjectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Projects = await _service.GetAllAsync();
            var ProjectDtos = _mapper.Map<List<ProjectDto>>(Projects.ToList());
            return CreateActionResult(CustomResponseDto<List<ProjectDto>>.Success(200, ProjectDtos));
        }

        //Get /api/Project/5
        [ServiceFilter(typeof(NotFoundFilter<Project>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var Project = await _service.GetByIdAsync(id);
            var ProjectDto = _mapper.Map<ProjectDto>(Project);
            return CreateActionResult(CustomResponseDto<ProjectDto>.Success(200, ProjectDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProjectDto ProjectDto)
        {
            var Project = await _service.AddAsync(_mapper.Map<Project>(ProjectDto));
            var ProjectsDto = _mapper.Map<ProjectDto>(Project);
            return CreateActionResult(CustomResponseDto<ProjectDto>.Success(201, ProjectsDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProjectDto ProjectDto)
        {
            await _service.UpdateAsync(_mapper.Map<Project>(ProjectDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        //Delete /api/Project/5
        [ServiceFilter(typeof(NotFoundFilter<Project>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var Project = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(Project);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        //// Get /api/Project/GetProjectByIdWithDetailsAsync
        [HttpGet("GetProjectByIdWithDetailsAsync")]
        public async Task<IActionResult> GetProjectByIdWithDetailsAsync(int id)
        {
            return CreateActionResult(await _service.GetProjectByIdWithDetailsAsync(id));
        }



    }
}
