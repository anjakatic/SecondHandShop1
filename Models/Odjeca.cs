using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SecondHandShop1.Models
{
    [Table("odjeca")]
        public class Odjeca
        {
            [Required]
            [Key]
            public int IdOdjece { get; set; }

            public bool Novo { get; set; }
            [Required(AllowEmptyStrings = false, ErrorMessage = "Materijal je obavezan podatak!")]
            [Display(Name = "Materijal")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string Materijal { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Velicina je obavezan podatak!")]
            [Display(Name = "Velicina")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string Velicina { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Boja je obavezan podatak!")]
            [Display(Name = "Boja")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string Boja { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Spol je obavezan podatak!")]
            [Display(Name = "Spol")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string Spol { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Cijena je obavezan podatak!")]
            [Display(Name = "Cijena")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string Cijena { get; set; }
            public byte[] Slika { get; set; }


            public VrstaOdjece VrstaOdjece { get; set; }

        }

    
}