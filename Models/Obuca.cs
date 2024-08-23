using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SecondHandShop1.Models
{
    [Table("obuca")]
    public class Obuca
    {
        [Required]
        [Key]
        public int IdObuca { get; set; }

        public bool Novo { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Materijal je obavezan podatak!")]
        [Display(Name = "Materijal")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public MaterijalObuca MaterijalObuca { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Velicina je obavezan podatak!")]
        [Display(Name = "Velicina")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public VelicinaObuce VelicinaObuce { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Boja je obavezan podatak!")]
        [Display(Name = "Boja")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public Boje Boje { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Cijena je obavezan podatak!")]
        [Display(Name = "Spol")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public Spol Spol { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Cijena je obavezan podatak!")]
        [Display(Name = "Cijena")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Cijena { get; set; }

        public VrstaObuce VrstaObuce { get; set; }

        public bool U_kosarici { get; set; }
    }
}