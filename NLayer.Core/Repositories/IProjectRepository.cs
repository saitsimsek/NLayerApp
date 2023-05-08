using NLayer.Core.DTOs;
using NLayer.Core.Models;

namespace NLayer.Core.Repositories
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        Task<List<Project>> GetProjectByIdWithDetailsAsync(int ProjectId);

        Task<List<Project>> GetProjectByIdWithPersonalsAsync(int ProjectId);

        
        Task<List<ApprovalStatus>> GetAllApprovalStatusAsync();
    }
}
