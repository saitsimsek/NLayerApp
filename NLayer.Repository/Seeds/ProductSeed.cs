using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = Guid.Parse("3AD3A0E4-B39C-4AE5-B4B1-23D31861F172"),
                CategoryId = Guid.Parse("2F09BF40-1528-4980-900F-716914ABFBF2"),
                Name = "Kalem 1",
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now


            },
            new Product
            {
                Id = Guid.Parse("F0AFFFEF-1810-426F-AD97-210C5F29DACB"),
                CategoryId = Guid.Parse("2F09BF40-1528-4980-900F-716914ABFBF2"),
                Name = "Kalem 2",
                Price = 200,
                Stock = 30,
                CreatedDate = DateTime.Now


            },
             new Product
             {
                 Id = Guid.Parse("FD75B515-B4A3-48D3-BF80-5976614C2323"),
                 CategoryId = Guid.Parse("11181A4E-AB99-42C5-805A-346E4C5F02BD"),
                 Name = "Kalem 3",
                 Price = 600,
                 Stock = 60,
                 CreatedDate = DateTime.Now


             },
               new Product
               {
                   Id = Guid.Parse("043BC4A7-5DBF-49EB-8317-DFC422186936"),
                   CategoryId = Guid.Parse("81E922C4-4E7F-4925-A9FD-7E9FF3266382\""),
                   Name = "Kitap 1",
                   Price = 600,
                   Stock = 60,
                   CreatedDate = DateTime.Now


               },
               new Product
               {
                   Id = Guid.Parse("009A95E2-1A1D-46E0-8E99-3349DB2DCC99"),
                   CategoryId = Guid.Parse("81E922C4-4E7F-4925-A9FD-7E9FF3266382\""),
                   Name = "Kitap 2",
                   Price = 6600,
                   Stock = 320,
                   CreatedDate = DateTime.Now


               });

        }
    }
}
