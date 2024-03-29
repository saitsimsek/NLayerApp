﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Purpose).HasMaxLength(100);
            builder.Property(x => x.Unit).HasMaxLength(100);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.ApprovalStatusId).IsRequired();
            builder.Property(x => x.PRM_ProjectTypeId).IsRequired();
            builder.Property(x => x.StrategicPlanCode).IsRequired();
            builder.Property(x => x.PlanState).IsRequired();
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.EndDate).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedPersonalId).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired();
            builder.Property(x => x.UpdatedPersonalId).IsRequired();
            builder.Property(x => x.State).IsRequired();
         
            builder.ToTable("Projects");

            builder.HasOne(x => x.CreatedPersonal).WithMany(x => x.ProjectsCreated).HasForeignKey(x => x.CreatedPersonalId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(x => x.UpdatedPersonal).WithMany(x => x.ProjectsUpdated).HasForeignKey(x => x.UpdatedPersonalId).OnDelete(DeleteBehavior.ClientSetNull); ;


        }
    }
}
