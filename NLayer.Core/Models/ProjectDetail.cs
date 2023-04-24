using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class ProjectDetail : BaseEntity
    {
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public string SubTechnologyName { get; set; }
        public string AvailableTRL { get; set; }
        public string GoalTRL { get; set; }
        public string AvailableTRLDocumentation { get; set; }
        public string RiskPlan { get; set; }
        public string ImportantConsiderations { get; set; } // Önemli Hususlar


    }
}
