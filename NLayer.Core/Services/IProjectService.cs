using NLayer.Core.DTOs;
using NLayer.Core.Models;

namespace NLayer.Core.Services
{
    public interface IProjectService:IService<Project>
    {
        Task<CustomResponseDto<List<ProjectWithDetailDto>>> GetProjectByIdWithDetailsAsync(int ProjectId);
    }
}
