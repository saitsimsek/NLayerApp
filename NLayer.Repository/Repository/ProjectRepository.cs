using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Core.Repositories;

namespace NLayer.Repository.Repository
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Project>> GetProjectByIdWithDetailsAsync(int ProjectId)
        {
            return await _context.Projects.Include(i => i.ProjectDetails).Include(i => i.ProjectDuration).Include(i => i.ProjectIncomeExpenses).Include(i => i.ProjectStages).ToListAsync();
        }

        public async Task<List<Project>> GetProjectByIdWithPersonalsAsync(int ProjectId)
        {
            return await _context.Projects.Include(i => i.ProjectPersonals).Include(i => i.ProjectStages).ToListAsync();
        }

        public async Task<List<ApprovalStatus>> GetAllApprovalStatusAsync()
        {
            return await _context.ApprovalStatuses.Where(w=>w.State).ToListAsync();
        }

    }
}
