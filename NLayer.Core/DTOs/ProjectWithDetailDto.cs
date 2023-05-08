namespace NLayer.Core.DTOs
{
    public class ProjectWithDetailDto 
    {
        public ProjectWithDetailDto()
        {
            Project = new ProjectDto();
            Details = new ProjectDetailDto();
            Output = new ProjectOutputDto();
            Stage = new ProjectStageDto();
            IncomeExpense = new ProjectIncomeExpenseDto();
        }

        public ProjectDto Project { get; set; }
        public ProjectDetailDto Details { get; set; }
        public ProjectOutputDto Output { get; set; }
        public ProjectStageDto Stage { get; set; }
        public ProjectIncomeExpenseDto IncomeExpense { get; set; }

    }

}
