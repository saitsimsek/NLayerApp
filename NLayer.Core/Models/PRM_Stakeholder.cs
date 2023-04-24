using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class PRM_Stakeholder
    {

        public Guid Id { get; set; }
        public decimal Name { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }

    }
}
