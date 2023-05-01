using NLayer.Core.DTOs;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class ProjectDto:BaseDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Adı Alanı zorunludur.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Amaç Alanı zorunludur.")]
        public string Purpose { get; set; } // Amaç
        [Required(ErrorMessage = "Birim Alanı zorunludur.")]
        public string Unit { get; set; }
        [Required(ErrorMessage = "Açıklama Alanı zorunludur.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Projenin Durumu Alanı zorunludur.")]
        public int ApprovalStatusId { get; set; }
        public string ApprovalStatusAck { get; set; }

    }
}

