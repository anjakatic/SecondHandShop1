using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecondHandShop1.Models
{
    [Table("korisnik")]
    public class Korisnik
    {
        [Key]
        public int IdKorisnik { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ime je obavezan podatak!")]
        

        public string Ime { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Prezime je obavezan podatak!")]
        public string Prezime { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Korisnicko ime je obavezan podatak!")]
        [StringLength(50)]
        public string KorisnickoIme { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Zaporka je obavezan podatak!")]
        [Column("zaporka")]
        [DataType(DataType.Password)]
        [StringLength(255)]
        public string Password { get; set; }
        public bool IsLogged { get; set; }
        public bool IsAdmin { get; set; } 
    }
}
