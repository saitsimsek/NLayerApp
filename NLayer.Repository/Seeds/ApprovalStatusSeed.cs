using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class ApprovalStatusSeed : IEntityTypeConfiguration<ApprovalStatus>
    {
        public void Configure(EntityTypeBuilder<ApprovalStatus> builder)
        {
            builder.HasData(
                new ApprovalStatus
                {
                    Id = 1,
                    Name = "Projet Approval 1",
                    Description = "Projet Approval Description",
                    State = true
                },
                new ApprovalStatus
                {
                    Id = 2,
                    Name = "Projet Approval 2",
                    Description = "Projet Approval Description",
                    State = true
                },
                new ApprovalStatus
                {
                    Id = 3,
                    Name = "Projet Approval 3",
                    Description = "Projet Approval Description",
                    State = true
                },
                 new ApprovalStatus
                 {
                     Id = 4,
                     Name = "Projet Approval 4",
                     Description = "Projet Approval Description",
                     State = true
                 },
                 new ApprovalStatus
                 {
                     Id = 5,
                     Name = "Projet Approval 5",
                     Description = "Projet Approval Description",
                     State = true
                 }
                );
        }

    }
}
