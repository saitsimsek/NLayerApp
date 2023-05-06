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
    internal class ProjectOutputConfiguration : IEntityTypeConfiguration<ProjectOutput>
    {
        public void Configure(EntityTypeBuilder<ProjectOutput> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.PRM_OutputId).IsRequired();
            builder.Property(x => x.PRM_DocumentId).IsRequired();
            builder.Property(x => x.PRM_LiableId).IsRequired();
            builder.Property(x => x.Product).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedPersonalId).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired();
            builder.Property(x => x.UpdatedPersonalId).IsRequired();
            builder.Property(x => x.State).IsRequired();
            builder.ToTable("ProjectOutputs");

            //builder.HasOne(x => x.Project).WithMany(x => x.ProjectDetails).HasForeignKey(x => x.ProjectId);
            builder.HasOne(x => x.CreatedPersonal).WithMany(x => x.ProjectOutputCreated).HasForeignKey(x => x.CreatedPersonalId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(x => x.UpdatedPersonal).WithMany(x => x.ProjectOutputUpdated).HasForeignKey(x => x.UpdatedPersonalId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
