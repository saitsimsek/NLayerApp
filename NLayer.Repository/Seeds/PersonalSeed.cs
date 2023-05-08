using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class PersonalSeed : IEntityTypeConfiguration<Personal>
    {
        public void Configure(EntityTypeBuilder<Personal> builder)
        {
            builder.HasData(
                new Personal
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "Admin Name 1",
                    SurName = "Admin SurName 1",
                    RegistrationNumber = "000",
                    Email = "admin@gmail.com",
                    PhoneNumber = "(505)0000000",
                    Position = "Sistem Yöneticisi",
                    Description = "Admin Description",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    State = true
                },
                new Personal
                {
                    Id = Guid.Parse("2F09BF40-1528-4980-900F-716914ABFBF2"),
                    Name = "Personel Name 1",
                    SurName = "Personal SurName 1",
                    RegistrationNumber = "123",
                    Email = "personal1@gmail.com",
                    PhoneNumber = "(505)5050001",
                    Position = "Müdür",
                    Description = "Personal 1 Description",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    State = true
                },
                new Personal
                {
                    Id = Guid.Parse("81E922C4-4E7F-4925-A9FD-7E9FF3266382"),
                    Name = "Personel Name 2",
                    SurName = "Personal SurName 2",
                    RegistrationNumber = "124",
                    Email = "personal2@gmail.com",
                    PhoneNumber = "(505)5050002",
                    Position = "Müdür Yardımcısı",
                    Description = "Personal 2 Description",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    State = true
                },
                new Personal
                {
                    Id = Guid.Parse("11181A4E-AB99-42C5-805A-346E4C5F02BD"),
                    Name = "Personel Name 3",
                    SurName = "Personal SurName 3",
                    RegistrationNumber = "125",
                    Email = "personal3@gmail.com",
                    PhoneNumber = "(505)5050003",
                    Position = "Mühendis",
                    Description = "Personal 3 Description",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    State = true
                },
                new Personal
                {
                    Id = Guid.Parse("9FB768EF-4F17-471D-B2E8-626B1BC48E02"),
                    Name = "Personel Name 4",
                    SurName = "Personal SurName 4",
                    RegistrationNumber = "126",
                    Email = "personal4@gmail.com",
                    PhoneNumber = "(505)5050004",
                    Position = "Mühendis",
                    Description = "Personal 4 Description",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    State = true
                },
                new Personal
                {
                    Id = Guid.Parse("F7F14713-D762-4714-BBC9-5111E5294494"),
                    Name = "Personel Name 5",
                    SurName = "Personal SurName 5",
                    RegistrationNumber = "127",
                    Email = "personal5@gmail.com",
                    PhoneNumber = "(505)5050005",
                    Position = "Mühendis",
                    Description = "Personal 5 Description",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    State = true
                },
                new Personal
                {
                    Id = Guid.Parse("A2E31A5D-6069-4EC8-8CE2-C65CC96D43FC"),
                    Name = "Personel Name 6",
                    SurName = "Personal SurName 6",
                    RegistrationNumber = "128",
                    Email = "personal6@gmail.com",
                    PhoneNumber = "(505)5050006",
                    Position = "Mühendis",
                    Description = "Personal 6 Description",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    State = true
                }
                );
        }

    }
}
