using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class PRM_ProjectTypeSeed : IEntityTypeConfiguration<PRM_ProjectType>
    {
        public void Configure(EntityTypeBuilder<PRM_ProjectType> builder)
        {
            builder.HasData(
                new PRM_ProjectType
                {
                    Id = 1,
                    Name = "Projet ProjectType 1",
                    Description = "Projet ProjectType Description",
                    State = true
                },
                new PRM_ProjectType
                {
                    Id =2,
                    Name = "Projet ProjectType 2",
                    Description = "Projet ProjectType Description",
                    State = true
                },
                new PRM_ProjectType
                {
                    Id = 3,
                    Name = "Projet ProjectType 3",
                    Description = "Projet ProjectType Description",
                    State = true
                },
                 new PRM_ProjectType
                 {
                     Id = 4,
                     Name = "Projet ProjectType 4",
                     Description = "Projet ProjectType Description",
                     State = true
                 },
                 new PRM_ProjectType
                 {
                     Id = 5,
                     Name = "Projet ProjectType 5",
                     Description = "Projet ProjectType Description",
                     State = true
                 }
                );
        }

    }
}
