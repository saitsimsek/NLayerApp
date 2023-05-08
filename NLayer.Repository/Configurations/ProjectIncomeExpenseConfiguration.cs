using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Configurations
{
    internal class ProjectIncomeExpenseConfiguration : IEntityTypeConfiguration<ProjectIncomeExpense>
    {
        public void Configure(EntityTypeBuilder<ProjectIncomeExpense> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Outsource).IsRequired();
            builder.Property(x => x.Time).IsRequired();
            builder.Property(x => x.Abroad).IsRequired();
            builder.Property(x => x.ProspectiveCustomer).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedPersonalId).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired();
            builder.Property(x => x.UpdatedPersonalId).IsRequired();
            builder.Property(x => x.State).IsRequired();
            builder.ToTable("ProjectIncomeExpenses");

            //builder.HasOne(x => x.Project).WithMany(x => x.ProjectDetails).HasForeignKey(x => x.ProjectId);

            builder.HasOne(x => x.CreatedPersonal).WithMany(x => x.ProjectIncomeExpenseCreated).HasForeignKey(x => x.CreatedPersonalId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(x => x.UpdatedPersonal).WithMany(x => x.ProjectIncomeExpenseUpdated).HasForeignKey(x => x.UpdatedPersonalId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
