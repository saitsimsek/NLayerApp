using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    public class PersonalService : Service<Personal>, IPersonalService
    {
        private readonly IPersonalRepository _personalRepository;
        private readonly IMapper _mapper;

        public PersonalService(IGenericRepository<Personal> repository, IUnitOfWork unitOfWork, IMapper mapper, IPersonalRepository personalRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _personalRepository = personalRepository;
        }

        public async Task<CustomResponseDto<List<PersonalWithProjetsDto>>> GetPersonalWithProjets()
        {
            var personals = await _personalRepository.GetPersonalProductsWithProject();

            var personalsDto = _mapper.Map<List<PersonalWithProjetsDto>>(personals);
            return CustomResponseDto<List<PersonalWithProjetsDto>>.Success(200, personalsDto);

        }

    }
}
