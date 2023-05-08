using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class PRM_LiableSeed : IEntityTypeConfiguration<PRM_Liable>
    {
        public void Configure(EntityTypeBuilder<PRM_Liable> builder)
        {
            builder.HasData(
                new PRM_Liable
                {
                    Id = 1,
                    Name = "Projet Liable 1",
                    Description = "Projet Liable Description",
                    State = true
                },
                new PRM_Liable
                {
                    Id =2,
                    Name = "Projet Liable 2",
                    Description = "Projet Liable Description",
                    State = true
                },
                new PRM_Liable
                {
                    Id = 3,
                    Name = "Projet Liable 3",
                    Description = "Projet Liable Description",
                    State = true
                },
                 new PRM_Liable
                 {
                     Id = 4,
                     Name = "Projet Liable 4",
                     Description = "Projet Liable Description",
                     State = true
                 },
                 new PRM_Liable
                 {
                     Id = 5,
                     Name = "Projet Liable 5",
                     Description = "Projet Liable Description",
                     State = true
                 }
                );
        }

    }
}
