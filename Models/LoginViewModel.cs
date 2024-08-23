using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SecondHandShop1.Models
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ime je obavezan podatak!")]
        [Display(Name = "Korisničko ime")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Lozinka je obavezan podatak!")]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka")]
        public string Password { get; set; }
    }
}
