using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Core.Repositories;

namespace NLayer.Repository.Repository
{
    public class PersonalRepository : GenericRepository<Personal>, IPersonalRepository
    {
        public PersonalRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Personal>> GetPersonalProductsWithProject()
        {
            return await _context.Personals.Include(i => i.ProjectsCreated).ToListAsync();
        }
    }
}
