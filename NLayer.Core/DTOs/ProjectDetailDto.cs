using System.ComponentModel.DataAnnotations;

namespace NLayer.Core.DTOs
{
    public class ProjectDetailDto : BaseDto
    {
        [Required(ErrorMessage = "Alt Teknolojiler Alanı zorunludur.")]
        [Display(Name = "Alt Teknolojiler")]
        public string SubTechnologyName { get; set; }
        [Required(ErrorMessage = "Mevcut TRL Alanı zorunludur.")]
        [Display(Name = "Mevcut TRL")]
        public string AvailableTRL { get; set; }
        [Required(ErrorMessage = "Hedef TRL Alanı zorunludur.")]
        [Display(Name = "Hedef TRL")]
        public string GoalTRL { get; set; }
        [Required(ErrorMessage = "Mevcut TRL Kanıt Dökümanı Alanı zorunludur.")]
        [Display(Name = "Mevcut TRL Kanıt Dökümanı")]
        public string AvailableTRLDocumentation { get; set; }
        [Required(ErrorMessage = "Risk Planı Alanı zorunludur.")]
        [Display(Name = "Risk Planı")]
        public string RiskPlan { get; set; }
        [Required(ErrorMessage = "Önemli Hususlar Alanı zorunludur.")]
        [Display(Name = "Önemli Hususlar")]
        public string ImportantConsiderations { get; set; } 

    }
}
 