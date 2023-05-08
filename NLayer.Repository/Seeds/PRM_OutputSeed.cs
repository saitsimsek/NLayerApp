using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class PRM_OutputSeed : IEntityTypeConfiguration<PRM_Output>
    {
        public void Configure(EntityTypeBuilder<PRM_Output> builder)
        {
            builder.HasData(
                new PRM_Output
                {
                    Id = 1,
                    Name = "Projet Output 1",
                    Description = "Projet Output Description",
                    State = true
                },
                new PRM_Output
                {
                    Id =2,
                    Name = "Projet Output 2",
                    Description = "Projet Output Description",
                    State = true
                },
                new PRM_Output
                {
                    Id = 3,
                    Name = "Projet Output 3",
                    Description = "Projet Output Description",
                    State = true
                },
                 new PRM_Output
                 {
                     Id = 4,
                     Name = "Projet Output 4",
                     Description = "Projet Output Description",
                     State = true
                 },
                 new PRM_Output
                 {
                     Id = 5,
                     Name = "Projet Output 5",
                     Description = "Projet Output Description",
                     State = true
                 }
                );
        }

    }
}
