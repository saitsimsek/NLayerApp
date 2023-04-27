using NLayer.Core.DTOs;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class ProjectDetailDto : BaseDto
    {
        public string SubTechnologyName { get; set; }
        public string AvailableTRL { get; set; }
        public string GoalTRL { get; set; }
        public string AvailableTRLDocumentation { get; set; }
        public string RiskPlan { get; set; }
        public string ImportantConsiderations { get; set; } // Önemli Hususlar

    }
}
 