using NLayer.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace NLayer.Core.DTOs
{
    public class ProjectOutputDto : BaseDto
    {
        public Guid ProjectId { get; set; }

        [Required(ErrorMessage = "Akademik Çıktılar Alanı zorunludur.")]
        [Display(Name = "Akademik Çıktılar")]
        public int PRM_OutputId { get; set; }
        public PRM_Output PRM_Output { get; set; }

        [Required(ErrorMessage = "Döküman Alanı zorunludur.")]
        [Display(Name = "Döküman")]
        public int PRM_DocumentId { get; set; }
        public PRM_Document PRM_Document { get; set; }

        [Required(ErrorMessage = "Sorumlu alanı zorunludur.")]
        [Display(Name = "Sorumlu")]
        public int PRM_LiableId { get; set; }
        public PRM_Liable PRM_Liable { get; set; } // Sorumlu

        [Required(ErrorMessage = "Ürün alanı zorunludur.")]
        [Display(Name = "Ürün")]
        public string Product { get; set; }

    }
}
 