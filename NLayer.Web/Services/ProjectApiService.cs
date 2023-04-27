using NLayer.Core.DTOs;

namespace NLayer.Web.Services
{
    public class ProjectApiService
    {
        private readonly HttpClient _httpClient;

        public ProjectApiService(HttpClient httpClient)
        {


            _httpClient = httpClient;
        }

        public async Task<List<ProjectDto>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<ProjectDto>>>("categories");
            return response.Data;
        }

    }
}
