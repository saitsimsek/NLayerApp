using NLayer.Core.Models;
using System.ComponentModel.DataAnnotations ;

namespace NLayer.Core.DTOs
{
    public class ProjectDto:BaseDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Projenin Adı Alanı zorunludur.")]
        [Display(Name = "Adı")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Projenin Amaç Alanı zorunludur.")]
        [Display(Name = "Projenin Amacı")]
        public string Purpose { get; set; } // Amaç
        [Required(ErrorMessage = "Projenin Birim Alanı zorunludur.")]
        [Display(Name = "Projenin Birimi")]
        public string Unit { get; set; }
        [Required(ErrorMessage = "Projenin Açıklama Alanı zorunludur.")]
        [Display(Name = "Projenin Açıklaması")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Proje Tipi Alanı zorunludur.")]
        [Display(Name = "Projen Tipi")]
        public int PRM_ProjectTypeId { get; set; }

        [Required(ErrorMessage = "Projenin Stratejik Plan Kodu Alanı zorunludur.")]
        [Display(Name = "Stratejik Plan Kodu")]
        public int StrategicPlanCode { get; set; }

        [Required(ErrorMessage = "Projenin Plan Durumu Alanı zorunludur.")]
        [Display(Name = "Plan Durumu")]
        public int PlanState { get; set; }

        [Required(ErrorMessage = "Projenin Başlangıç Tarihi zorunludur.")]
        [Display(Name = "Başlangıç Tarihi")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Projenin Bitiş Tarihi zorunludur.")]
        [Display(Name = "Bitiş Tarihi")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Projenin Süresi zorunludur.")]
        [Display(Name = "Süresi Açıklaması")]
        public string ProjectDuration { get; set; }

        [Required(ErrorMessage = "Projenin Durumu Alanı zorunludur.")]
        [Display(Name = "Projenin Durumu")]
        public int? ApprovalStatusId { get; set; }
        public string ApprovalStatusAck { get; set; }

        public ProjectDetailDto ProjectDetailDto { get; set; }


    }
}

