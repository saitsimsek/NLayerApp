using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class ProjectSeeds : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasData(new Project()
            {
                Id = Guid.Parse("4C547E3F-1893-45EA-ABE1-329379EBDAA5"),
                Name = "Proje A",
                Purpose = "Proje A Purpose",
                Unit = "Proje A Unit",
                Description = "Proje A Description",
                ApprovalStatusId = 1,
                PlanState =0,
                StartDate= DateTime.Now,
                EndDate = DateTime.Now.AddMonths(12),
                StrategicPlanCode = 12345,
                PRM_ProjectTypeId=1,
                CreatedDate = DateTime.Now,
                CreatedPersonalId =Guid.Parse("00000000-0000-0000-0000-000000000001"),
                UpdatedDate = DateTime.Now,
                UpdatedPersonalId =Guid.Parse("00000000-0000-0000-0000-000000000001"),
                State = true
            },
             new Project()
             {
                 Id = Guid.Parse("E9567F76-4ED8-48B7-B30D-EBAFAA8B909E"),
                 Name = "Proje B",
                 Purpose = "Proje B Purpose",
                 Unit = "Proje B Unit",
                 Description = "Proje B Description",
                 ApprovalStatusId = 1,
                 PlanState = 0,
                 StartDate = DateTime.Now,
                 EndDate = DateTime.Now.AddMonths(12),
                 StrategicPlanCode = 12345,
                 PRM_ProjectTypeId = 1,
                 CreatedDate = DateTime.Now,
                 CreatedPersonalId =Guid.Parse("00000000-0000-0000-0000-000000000001"),
                 UpdatedDate = DateTime.Now,
                 UpdatedPersonalId =Guid.Parse("00000000-0000-0000-0000-000000000001"),
                 State = true
             },
            new Project()
            {
                Id = Guid.Parse("841ECCF0-B978-442C-A5CB-D0808BC7439B"),
                Name = "Proje C",
                Purpose = "Proje C Purpose",
                Unit = "Proje C Unit",
                Description = "Proje C Description",
                ApprovalStatusId = 1,
                PlanState = 0,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(12),
                StrategicPlanCode = 12345,
                PRM_ProjectTypeId = 1,
                CreatedDate = DateTime.Now,
                CreatedPersonalId =Guid.Parse("00000000-0000-0000-0000-000000000001"),
                UpdatedDate = DateTime.Now,
                UpdatedPersonalId =Guid.Parse("00000000-0000-0000-0000-000000000001"),
                State = true
            });
        }
    }

}
