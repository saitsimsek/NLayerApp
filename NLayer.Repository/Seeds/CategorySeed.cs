using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = Guid.Parse("2F09BF40-1528-4980-900F-716914ABFBF2"), Name = "Kalemler" },
                new Category { Id = Guid.Parse("81E922C4-4E7F-4925-A9FD-7E9FF3266382"), Name = "Kitaplar" },
                new Category { Id = Guid.Parse("11181A4E-AB99-42C5-805A-346E4C5F02BD"), Name = "Defterler" });
        }
    }
}
