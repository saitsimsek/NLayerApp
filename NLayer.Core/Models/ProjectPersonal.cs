using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class ProjectPersonal: BaseEntity
    {
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid PersonalId { get; set; }
        public Personal Personal { get; set; }
        public Guid PersonalTitleId { get; set; }
        public PersonalTitle PersonalTitle { get; set; }

    }
}
