using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductFeatureSeeds : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(new ProductFeature()
            {
                Id = Guid.Parse("4C547E3F-1893-45EA-ABE1-329379EBDAA5"),
                Color = "Kırmızı",
                Height = 100,
                Width = 200,
                ProductId = Guid.Parse("3AD3A0E4-B39C-4AE5-B4B1-23D31861F172")
            },
             new ProductFeature()
             {
                 Id = Guid.Parse("E9567F76-4ED8-48B7-B30D-EBAFAA8B909E"),
                 Color = "Mavi",
                 Height = 300,
                 Width = 500,
                 ProductId = Guid.Parse("F0AFFFEF-1810-426F-AD97-210C5F29DACB")
             }
             );
        }
    }


}
