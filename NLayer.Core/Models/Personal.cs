using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Personal : BaseEntity
    {

        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        //public string Administrator { get; set; }
        //public string TechnicalAdministrator { get; set; }
        //public string Manager { get; set; }


    }
}
