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
            return await _context.Projects.Include(i => i.ProjectDetails).ToListAsync();
        }

    }
}
