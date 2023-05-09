using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;
using System.Xml.Linq;

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

            var projects = await _service.GetAllAsync();
            List<ProjectDto> projectDtos = projects.Select(s => new ProjectDto
            {
                Id = s.Id,
                Name = s.Name,
                Purpose = s.Purpose,
                Unit = s.Unit,
                Description = s.Description,
                StartDate = s.StartDate,
                EndDate = s.EndDate,
                ApprovalStatusId = s.ApprovalStatusId
            }).ToList();


            // var ProjectDtos = _mapper.Map<List<ProjectDto>>(Projects.ToList());
            return CreateActionResult(CustomResponseDto<List<ProjectDto>>.Success(200, projectDtos));
        }

        //Get /api/Project/5
        [ServiceFilter(typeof(NotFoundFilter<Project>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(Guid id)
        {
            var Project = await _service.GetByIdAsync(id);
            var ProjectDto = _mapper.Map<ProjectDto>(Project);
            return CreateActionResult(CustomResponseDto<ProjectDto>.Success(200, ProjectDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProjectWithDetailDto projectWithDetailDto)
        {
            Guid projectId = Guid.NewGuid();

            List<ProjectDetail> details = new List<ProjectDetail>();
            details.Add(new ProjectDetail
            {
                Id = Guid.NewGuid(),
                ProjectId= projectId,
                SubTechnologyName = projectWithDetailDto.Details.SubTechnologyName,
                AvailableTRL = projectWithDetailDto.Details.AvailableTRL,
                GoalTRL = projectWithDetailDto.Details.GoalTRL,
                AvailableTRLDocumentation = projectWithDetailDto.Details.AvailableTRLDocumentation,
                RiskPlan = projectWithDetailDto.Details.RiskPlan,
                ImportantConsiderations = projectWithDetailDto.Details.ImportantConsiderations,
                CreatedPersonalId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                CreatedDate = DateTime.Now,
                UpdatedPersonalId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                UpdatedDate = DateTime.Now,
                State = true
            });

            List<ProjectOutput> outputs = new List<ProjectOutput>();
            outputs.Add(new ProjectOutput
            {
                Id = Guid.NewGuid(),
                ProjectId = projectId,
                PRM_OutputId = projectWithDetailDto.Output.PRM_OutputId,
                PRM_DocumentId = projectWithDetailDto.Output.PRM_DocumentId,
                PRM_LiableId = projectWithDetailDto.Output.PRM_LiableId,
                Product = projectWithDetailDto.Output.Product,
                CreatedPersonalId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                CreatedDate = DateTime.Now,
                UpdatedPersonalId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                UpdatedDate = DateTime.Now,
                State = true
            });

            Project project = new Project
            {
                Id = projectId,
                Name = projectWithDetailDto.Project.Name,
                Purpose = projectWithDetailDto.Project.Purpose,
                Unit = projectWithDetailDto.Project.Unit,
                Description = projectWithDetailDto.Project.Description,
                ApprovalStatusId = projectWithDetailDto.Project.ApprovalStatusId.Value,
                StartDate= projectWithDetailDto.Project.StartDate,
                EndDate = projectWithDetailDto.Project.EndDate,
                PRM_ProjectTypeId = projectWithDetailDto.Project.PRM_ProjectTypeId,
                PlanState= projectWithDetailDto.Project.PlanState,
                ProjectDuration= projectWithDetailDto.Project.ProjectDuration,
                CreatedPersonalId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                CreatedDate = DateTime.Now,
                UpdatedPersonalId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                UpdatedDate = DateTime.Now,
                State = true,
                ProjectDetails = details,
                ProjectOutputs = outputs
            };

            await _service.AddAsync(project);
            return CreateActionResult(CustomResponseDto<ProjectWithDetailDto>.Success(201, projectWithDetailDto));
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
        public async Task<IActionResult> Remove(Guid id)
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

        [HttpGet("GetAllApprovalStatusAsync")]
        public async Task<IActionResult> GetAllApprovalStatusAsync()
        {
            return CreateActionResult(await _service.GetAllApprovalStatusAsync());
        }



    }
}
