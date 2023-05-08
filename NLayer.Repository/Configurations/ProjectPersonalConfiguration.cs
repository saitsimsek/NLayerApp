using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class ProjectPersonalConfiguration : IEntityTypeConfiguration<ProjectPersonal>
    {
        public void Configure(EntityTypeBuilder<ProjectPersonal> builder)
        {
            builder.HasKey(x => x.Id);
           // builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedPersonalId).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired();
            builder.Property(x => x.UpdatedPersonalId).IsRequired();
            builder.Property(x => x.State).IsRequired();
            builder.ToTable("ProjectPersonals");

            //builder.HasOne(x => x.Personal).WithMany(x => x.ProjectPersonals).HasForeignKey(x => x.PersonalId);
            //builder.HasOne(x => x.Project).WithMany(x => x.ProjectPersonals).HasForeignKey(x => x.ProjectId);
            //builder.HasOne(x => x.PersonalTitle).WithMany(x => x.ProjectPersonals).HasForeignKey(x => x.PersonalTitleId);

            builder.HasOne(x => x.CreatedPersonal).WithMany(x => x.ProjectPersonalsCreated).HasForeignKey(x => x.CreatedPersonalId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(x => x.UpdatedPersonal).WithMany(x => x.ProjectPersonalsUpdated).HasForeignKey(x => x.UpdatedPersonalId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
