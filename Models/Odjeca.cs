using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecondHandShop1.Models
{
    [Table("odjeca")]
    public class Odjeca
    {
        [Required]
        [Key]
        public int IdOdjeca { get; set; }

        public bool Novo { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Materijal je obavezan podatak!")]
        [Display(Name = "Materijal")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public MaterijalOdjeca MaterijalOdjeca { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Velicina je obavezan podatak!")]
        [Display(Name = "Velicina")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public VelicinaOdjeca VelicinaOdjeca { get; set; }

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

        public VrstaOdjece VrstaOdjece { get; set; }

        public bool U_kosarici { get; set; }
    }
}