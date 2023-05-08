using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class ProjectStage : BaseEntity
    {
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public decimal Name { get; set; }
        public string Description { get; set; }
        public int Percentage { get; set; } // Yüzde
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ProjectDuration { get; set; }
        public int PRM_LiableId { get; set; }
        public PRM_Liable PRM_Liable { get; set; } // Sorumlu
        public int PRM_StakeholderId { get; set; } //Paydaş
        public PRM_Stakeholder PRM_Stakeholder { get; set; }



    }
}
