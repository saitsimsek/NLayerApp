using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class ProjectOutput : BaseEntity
    {
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public int PRM_OutputId { get; set; }
        public PRM_Output PRM_Output { get; set; }
        public int PRM_DocumentId { get; set; }
        public PRM_Document PRM_Document { get; set; }
        public int PRM_LiableId { get; set; }
        public PRM_Liable PRM_Liable { get; set; } // Sorumlu
        public string Product { get; set; }

    }
}
