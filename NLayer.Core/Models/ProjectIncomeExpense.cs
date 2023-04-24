using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class ProjectIncomeExpense : BaseEntity
    {
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public decimal Name { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public bool Outsource { get; set; }
        public int? Time { get; set; }
        public bool Abroad { get; set; }
        public string ProspectiveCustomer { get; set;} // Muhtemel Müşteri

    }
}
