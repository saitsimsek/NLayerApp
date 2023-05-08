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
    internal class ProjectStageConfiguration : IEntityTypeConfiguration<ProjectStage>
    {
        public void Configure(EntityTypeBuilder<ProjectStage> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ProjectId).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Percentage).IsRequired();
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.EndDate).IsRequired();
            builder.Property(x => x.ProjectDuration).IsRequired();
            builder.Property(x => x.PRM_LiableId).IsRequired();
            builder.Property(x => x.PRM_StakeholderId).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedPersonalId).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired();
            builder.Property(x => x.UpdatedPersonalId).IsRequired();
            builder.Property(x => x.State).IsRequired();
            builder.ToTable("ProjectStages");

            //builder.HasOne(x => x.Project).WithMany(x => x.ProjectStages).HasForeignKey(x => x.ProjectId);


            builder.HasOne(x => x.CreatedPersonal).WithMany(x => x.ProjectStageCreated).HasForeignKey(x => x.CreatedPersonalId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(x => x.UpdatedPersonal).WithMany(x => x.ProjectStageUpdated).HasForeignKey(x => x.UpdatedPersonalId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
