using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Personal 
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string RegistrationNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool State { get; set; }

        public ICollection<Project> ProjectsCreated { get; set; }
        public ICollection<Project> ProjectsUpdated { get; set; }
        [NotMapped]
        public ICollection<PersonalTitle> PersonalTitlesCreated { get; set; }
        [NotMapped]
        public ICollection<PersonalTitle> PersonalTitlesUpdated { get; set; }
        [NotMapped]
        public ICollection<ProjectDetail> ProjectDetailsCreated { get; set; }
        [NotMapped]
        public ICollection<ProjectDetail> ProjectDetailsUpdated { get; set; }

        [NotMapped]
        public ICollection<ProjectPersonal> ProjectPersonalsCreated { get; set; }
        [NotMapped]
        public ICollection<ProjectPersonal> ProjectPersonalsUpdated { get; set; }

        [NotMapped]
        public ICollection<ProjectIncomeExpense> ProjectIncomeExpenseCreated { get; set; }
        [NotMapped]
        public ICollection<ProjectIncomeExpense> ProjectIncomeExpenseUpdated { get; set; }

        [NotMapped]
        public ICollection<ProjectOutput> ProjectOutputCreated { get; set; }
        [NotMapped]
        public ICollection<ProjectOutput> ProjectOutputUpdated { get; set; }

        [NotMapped]
        public ICollection<ProjectStage> ProjectStageCreated { get; set; }
        [NotMapped]
        public ICollection<ProjectStage> ProjectStageUpdated { get; set; }


    }
}
