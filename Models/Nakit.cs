using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SecondHandShop1.Models
{
    [Table("nakit")]
    public class Nakit
    {
        [Required]
        [Key]
        public int IdNakit { get; set; }

        public bool Novo { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Materijal je obavezan podatak!")]
        [Display(Name = "MaterijalNakit")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public MaterijalNakit MaterijalNakit { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Velicina je obavezan podatak!")]
        [Display(Name = "VelicinaNakita")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public VelicinaNakita VelicinaNakita { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Boja je obavezan podatak!")]
        [Display(Name = "Boje")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public Boje Boje { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Spol je obavezan podatak!")]
        [Display(Name = "Spol")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public Spol Spol { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Cijena je obavezan podatak!")]
        [Display(Name = "Cijena")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Cijena { get; set; }


        public VrstaNakita VrstaNakita { get; set; }

        public bool U_kosarici { get; set; }
    }
}