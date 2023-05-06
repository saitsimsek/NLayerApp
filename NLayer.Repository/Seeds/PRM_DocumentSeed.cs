using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class PRM_DocumentSeed : IEntityTypeConfiguration<PRM_Document>
    {
        public void Configure(EntityTypeBuilder<PRM_Document> builder)
        {
            builder.HasData(
                new PRM_Document
                {
                    Id = 1,
                    Name = "Projet Document 1",
                    Description = "Projet Document Description",
                    State = true
                },
                new PRM_Document
                {
                    Id =2,
                    Name = "Projet Document 2",
                    Description = "Projet Document Description",
                    State = true
                },
                new PRM_Document
                {
                    Id = 3,
                    Name = "Projet Document 3",
                    Description = "Projet Document Description",
                    State = true
                },
                 new PRM_Document
                 {
                     Id = 4,
                     Name = "Projet Document 4",
                     Description = "Projet Document Description",
                     State = true
                 },
                 new PRM_Document
                 {
                     Id = 5,
                     Name = "Projet Document 5",
                     Description = "Projet Document Description",
                     State = true
                 }
                );
        }

    }
}
