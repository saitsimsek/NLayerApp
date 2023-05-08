using NLayer.Core.DTOs;
using NLayer.Core.Models;

namespace NLayer.Core.Services
{
    public interface IPersonalService:IService<Personal>
    {
        Task<CustomResponseDto<List<PersonalWithProjetsDto>>> GetPersonalWithProjets();
    }
}
