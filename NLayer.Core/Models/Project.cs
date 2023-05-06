using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public int PRM_ProjectTypeId { get; set; }
        public PRM_ProjectType PRM_ProjectType { get; set; }
        public int StrategicPlanCode { get; set; } // stratejik plan kodu
        public int PlanState { get; set; } 
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ProjectDuration { get; set; } // Süre
        public string Purpose { get; set; } // Amaç
        public string Unit { get; set; } 
        public int ApprovalStatusId { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }

        public ICollection<ProjectPersonal> ProjectPersonals { get; set; }
        public ICollection<ProjectDetail> ProjectDetails { get; set; }
        public ICollection<ProjectIncomeExpense> ProjectIncomeExpenses { get; set; }
        public ICollection<ProjectOutput> ProjectOutputs { get; set; }
        public ICollection<ProjectStage> ProjectStages { get; set; }



    }
}
