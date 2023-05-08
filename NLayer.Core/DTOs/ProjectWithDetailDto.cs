namespace NLayer.Core.DTOs
{
    public class ProjectWithDetailDto 
    {
        public ProjectWithDetailDto()
        {
            Project = new ProjectDto();
            Details = new ProjectDetailDto();
        }

        public ProjectDto Project { get; set; }

        public ProjectDetailDto Details { get; set; }
    }

}
