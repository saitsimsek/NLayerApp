using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public Guid CreatedPersonalId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UpdatedPersonalId { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Personal CreatedPersonal { get; set; }
        public Personal UpdatedPersonal { get; set; }
        public bool State { get; set; }



    }
}
