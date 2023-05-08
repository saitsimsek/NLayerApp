using NLayer.Core.DTOs;

namespace NLayer.Web.Services
{
    public class PersonalApiService
    {
        private readonly HttpClient _httpClient;

        public PersonalApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PersonalWithProjetsDto>> GetPersonalsWithProjectsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<PersonalWithProjetsDto>>>("personals/GetPersonalWithProjets");

            return response.Data;
        }

        public async Task<List<PersonalDto>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<PersonalDto>>>("personals");
            return response.Data;
        }

        public async Task<PersonalDto> GetByIdAsync(int id)
        {

            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<PersonalDto>>($"personals/{id}");
            return response.Data;


        }

        public async Task<PersonalDto> SaveAsync(PersonalDto newPersonal)
        {
            var response = await _httpClient.PostAsJsonAsync("personals", newPersonal);

            if (!response.IsSuccessStatusCode) return null;

            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<PersonalDto>>();

            return responseBody.Data;


        }
        public async Task<bool> UpdateAsync(PersonalDto newPersonal)
        {
            var response = await _httpClient.PutAsJsonAsync("personals", newPersonal);

            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"personals/{id}");

            return response.IsSuccessStatusCode;
        }

    }
}
