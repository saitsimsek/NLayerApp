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
    internal class ProjectDetailConfiguration : IEntityTypeConfiguration<ProjectDetail>
    {
        public void Configure(EntityTypeBuilder<ProjectDetail> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedPersonalId).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired();
            builder.Property(x => x.UpdatedPersonalId).IsRequired();
            builder.Property(x => x.State).IsRequired();
            builder.ToTable("ProjectDetails");

            //builder.HasOne(x => x.Project).WithMany(x => x.ProjectDetails).HasForeignKey(x => x.ProjectId);
            builder.HasOne(x => x.CreatedPersonal).WithMany(x => x.ProjectDetailsCreated).HasForeignKey(x => x.CreatedPersonalId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(x => x.UpdatedPersonal).WithMany(x => x.ProjectDetailsUpdated).HasForeignKey(x => x.UpdatedPersonalId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
