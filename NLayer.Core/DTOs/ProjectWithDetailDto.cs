using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Core.DTOs_Temp;
using NLayer.Core.Models;

namespace NLayer.Core.DTOs
{
    public class ProjectWithDetailDto : ProjectDto
    {
        public List<ProjectDetailDto> Details { get; set; }
    }

}
