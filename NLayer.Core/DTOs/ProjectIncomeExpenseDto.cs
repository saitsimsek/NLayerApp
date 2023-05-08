using NLayer.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace NLayer.Core.DTOs
{
    public class ProjectIncomeExpenseDto : BaseDto
    {
        [Required(ErrorMessage = "Gelir/Gider Adı Alanı zorunludur.")]
        [Display(Name = "Gelir/Gider Adı")]
        public int Name { get; set; }
        [Required(ErrorMessage = "Gelir/Gider Tipi Alanı zorunludur.")]
        [Display(Name = "Gelir/Gider Tipi")]
        public int Type { get; set; }
        [Required(ErrorMessage = "Tutar Alanı zorunludur.")]
        [Display(Name = "Tutar")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Gelir/Gider Açıklama Alanı zorunludur.")]
        [Display(Name = "Gelir/Gider Açıklama")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Dış Kaynak Mı? Alanı zorunludur.")]
        [Display(Name = "Dış Kaynak Mı?")]
        public bool Outsource { get; set; }

        [Required(ErrorMessage = "İşçilik Süresi Alanı zorunludur.")]
        [Display(Name = "İşçilik Süresi")]
        public int? Time { get; set; }

        [Required(ErrorMessage = "Yurtdışı Müşterisi Mi? Alanı zorunludur.")]
        [Display(Name = "Yurtdışı Müşterisi Mi?")]
        public bool Abroad { get; set; }

        [Required(ErrorMessage = "Muhtemal Müşterisi Alanı zorunludur.")]
        [Display(Name = "Muhtemal Müşterisi")]
        public string ProspectiveCustomer { get; set; } // Muhtemel Müşteri


    }
}
 