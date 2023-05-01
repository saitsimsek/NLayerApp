using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IPersonalService _service;
        public PersonalsController(IMapper mapper, IPersonalService PersonalService)
        {

            _mapper = mapper;
            _service = PersonalService;
        }

        /// GET api/Personals/GetPersonalWithProjets
        [HttpGet("[action]")]
        public async Task<IActionResult> GetPersonalWithProjets()
        {
            return CreateActionResult(await _service.GetPersonalWithProjets());
        }

        //Get /api/Personals
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Personals = await _service.GetAllAsync();
            var PersonalsDtos = _mapper.Map<List<PersonalDto>>(Personals.ToList());
            return CreateActionResult(CustomResponseDto<List<PersonalDto>>.Success(200, PersonalsDtos));
        }


        //Get /api/Personals/5
        //[ServiceFilter(typeof(NotFoundFilter<Personal>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(Guid id)
        {
            var personal = await _service.GetByIdAsync(id);
            var personalsDto = _mapper.Map<PersonalDto>(personal);
            return CreateActionResult(CustomResponseDto<PersonalDto>.Success(200, personalsDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(PersonalDto PersonalDto)
        {
            var Personal = await _service.AddAsync(_mapper.Map<Personal>(PersonalDto));
            var PersonalsDto = _mapper.Map<PersonalDto>(Personal);
            return CreateActionResult(CustomResponseDto<PersonalDto>.Success(201, PersonalsDto));
        }

        //[HttpPut]
        //public async Task<IActionResult> Update(PersonalUpdateDto PersonalDto)
        //{
        //    await _service.UpdateAsync(_mapper.Map<Personal>(PersonalDto));
        //    return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        //}
        //Delete /api/Personals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(Guid id)
        {
            var Personal = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(Personal);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        //// Get /api/Personals/GetPersonalWithProjets
        //[HttpGet("[action]")]
        //public async Task<IActionResult> GetPersonalWithProjets()
        //{
        //    return CreateActionResult(await _service.GetPersonalWithProjets());
        //}
    }
}
