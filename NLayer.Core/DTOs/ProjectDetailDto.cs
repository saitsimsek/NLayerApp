using NLayer.Core.DTOs;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NLayer.Core.DTOs
{
    public class ProjectDetailDto : BaseDto
    {
        [Required(ErrorMessage = "Adı Alanı zorunludur.")]
        [Display(Name = "Adı")]
        public string SubTechnologyName { get; set; }
        [Required(ErrorMessage = "Adı Alanı zorunludur.")]
        [Display(Name = "Adı")]
        public string AvailableTRL { get; set; }
        [Required(ErrorMessage = "Adı Alanı zorunludur.")]
        [Display(Name = "Adı")]
        public string GoalTRL { get; set; }
        [Required(ErrorMessage = "Adı Alanı zorunludur.")]
        [Display(Name = "Adı")]
        public string AvailableTRLDocumentation { get; set; }
        [Required(ErrorMessage = "Risk Planı Alanı zorunludur.")]
        [Display(Name = "Risk Planı")]
        public string RiskPlan { get; set; }
        [Required(ErrorMessage = "Önemli Hususlar Alanı zorunludur.")]
        [Display(Name = "Önemli Hususlar")]
        public string ImportantConsiderations { get; set; } // Önemli Hususlar

    }
}
 