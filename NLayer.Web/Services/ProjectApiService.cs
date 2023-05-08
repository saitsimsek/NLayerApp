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
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<ProjectDto>>>("projects");
            return response.Data;
        }

        public async Task<ProjectDto> GetByIdAsync(Guid id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<ProjectDto>>($"projects/{id}");
            return response.Data;
        }

        public async Task<ProjectWithDetailDto> SaveAsync(ProjectWithDetailDto newProject)
        {
            var response = await _httpClient.PostAsJsonAsync("projects", newProject);
            if (!response.IsSuccessStatusCode) return null;
            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<ProjectWithDetailDto>>();
            return responseBody.Data;
        }
        public async Task<bool> UpdateAsync(ProjectDto newProject)
        {
            var response = await _httpClient.PutAsJsonAsync("projects", newProject);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RemoveAsync(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"projects/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<EnumDto>> GetAllApprovalStatusAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<EnumDto>>>("projects/GetAllApprovalStatusAsync");
            return response.Data;
        }
    }
}
