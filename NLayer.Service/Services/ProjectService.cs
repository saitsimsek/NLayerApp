using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    public class ProjectService : Service<Project>, IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;
        public ProjectService(IGenericRepository<Project> repository, IUnitOfWork unitOfWork, IMapper mapper, IProjectRepository ProjectRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _projectRepository = ProjectRepository;
        }


        public async Task<CustomResponseDto<List<ProjectWithDetailDto>>> GetProjectByIdWithDetailsAsync(int ProjectId)
        {
            var project = await _projectRepository.GetProjectByIdWithDetailsAsync(ProjectId);
            var projectDto = _mapper.Map<List<ProjectWithDetailDto>>(project);
            return CustomResponseDto<List<ProjectWithDetailDto>>.Success(200, projectDto);
        }

        public async Task<CustomResponseDto<List<EnumDto>>> GetAllApprovalStatusAsync()
        {
            var enumData = await _projectRepository.GetAllApprovalStatusAsync();
            List<EnumDto> enumDto = enumData.Select(s=> new EnumDto
            {
                Id = s.Id,
                Name = s.Name,  
                Description= s.Description,
                State= s.State
            }).ToList();
            return CustomResponseDto<List<EnumDto>>.Success(200, enumDto);
        }
    }
}
