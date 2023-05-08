using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class PRM_StakeholderSeed : IEntityTypeConfiguration<PRM_Stakeholder>
    {
        public void Configure(EntityTypeBuilder<PRM_Stakeholder> builder)
        {
            builder.HasData(
                new PRM_Stakeholder
                {
                    Id = 1,
                    Name = "Projet Stakeholder 1",
                    Description = "Projet Stakeholder Description",
                    State = true
                },
                new PRM_Stakeholder
                {
                    Id =2,
                    Name = "Projet Stakeholder 2",
                    Description = "Projet Stakeholder Description",
                    State = true
                },
                new PRM_Stakeholder
                {
                    Id = 3,
                    Name = "Projet Stakeholder 3",
                    Description = "Projet Stakeholder Description",
                    State = true
                },
                 new PRM_Stakeholder
                 {
                     Id = 4,
                     Name = "Projet Stakeholder 4",
                     Description = "Projet Stakeholder Description",
                     State = true
                 },
                 new PRM_Stakeholder
                 {
                     Id = 5,
                     Name = "Projet Stakeholder 5",
                     Description = "Projet Stakeholder Description",
                     State = true
                 }
                );
        }

    }
}
