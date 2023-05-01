namespace NLayer.Core.DTOs
{
    public class ProjectWithDetailDto : ProjectDto
    {
        public List<ProjectDetailDto> Details { get; set; }
    }

}
