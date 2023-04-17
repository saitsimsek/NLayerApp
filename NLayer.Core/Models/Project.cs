using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
    }
}
