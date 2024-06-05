using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SecondHandShop1.Models
{
    [Table("korisnik")]
    public class Korisnik
    {
        [Required]
        [Key]
        public int IdKorisnik { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ime je obavezan podatak!")]
        [Display(Name = "Ime")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Ime { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Prezime je obavezan podatak!")]
        [Display(Name = "Prezime")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]

        public string Prezime { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password je obavezan podatak!")]
        [Display(Name = "Password")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Password { get; set; }

    }
}
