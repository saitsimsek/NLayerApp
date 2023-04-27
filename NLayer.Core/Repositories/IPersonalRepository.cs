using NLayer.Core.Models;

namespace NLayer.Core.Repositories
{
    public interface IPersonalRepository : IGenericRepository<Personal>
    {
        Task<List<Personal>> GetPersonalProductsWithProject();

    }
}
