using NLayer.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace NLayer.Core.DTOs
{
    public class ProjectStageDto : BaseDto
    {
        public Guid ProjectId { get; set; }

        [Required(ErrorMessage = "Aşama Adı Alanı zorunludur.")]
        [Display(Name = "Aşama Adı")]
        public decimal Name { get; set; }
        [Required(ErrorMessage = "Aşama Açıklama Alanı zorunludur.")]
        [Display(Name = "Aşama Açıklama")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Aşama Ağırlık Oranı Alanı zorunludur.")]
        [Display(Name = "Aşama Ağırlık Oranı")]
        public int Percentage { get; set; } // Yüzde
        [Required(ErrorMessage = "Aşama Başlangıç Tarihi Alanı zorunludur.")]
        [Display(Name = "Aşama Başlangıç Tarihi")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Aşama Bitiş Tarihi Alanı zorunludur.")]
        [Display(Name = "Aşama Bitiş Tarihi")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Aşama Süresi Alanı zorunludur.")]
        [Display(Name = "Aşama Süresi")]
        public string ProjectDuration { get; set; }
        public int PRM_LiableId { get; set; }
        [Required(ErrorMessage = "Sorumlu Alanı zorunludur.")]
        [Display(Name = "Sorumlu")]
        public PRM_Liable PRM_Liable { get; set; } // Sorumlu
        [Required(ErrorMessage = "Paydaş Alanı zorunludur.")]
        [Display(Name = "Paydaş")]
        public int PRM_StakeholderId { get; set; } //Paydaş
        public PRM_Stakeholder PRM_Stakeholder { get; set; }

    }
}
 