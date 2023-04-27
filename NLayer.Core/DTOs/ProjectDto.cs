using NLayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class ProjectDto:BaseDto
    {
        public string Name { get; set; }
        public string Purpose { get; set; } // Amaç
        public string Unit { get; set; }
        public string Description { get; set; }
        public int ApprovalStatusId { get; set; }
        public string ApprovalStatus { get; set; }


    }
}
 