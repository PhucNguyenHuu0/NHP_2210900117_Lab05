using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace lab05.Models
{
    public class NHPSong
    {
        public int id { get; set; }
        [DisplayName("tieu de")]
        [Required(ErrorMessage = "NHP:hay nhap tieu de")]
        public string nhpTitle { get; set; }
        [DisplayName("tac gia")]
        [Required(ErrorMessage = "NHP:hay nhap tac gia")]
        public string nhpAuthor { get; set; }
        [DisplayName("nghe si")]
        [Required(ErrorMessage = "NHP:hay nhap nghe si")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "NHP: dai phai trong khoang[2-50]")]
        public string nhpArtist { get; set; }
        [DisplayName("nam xuat ban")]
        [Required(ErrorMessage = "NHP:hay nhap nam xuat ban")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "NHP: nam xuat ban phai la so co ki tu" )]
        [Range(1900,2020, ErrorMessage ="NHP nam xuat ban trong khoang 1900 - 2020")]
        public int nhpYaerRelease { get; set; }
        
    }
}