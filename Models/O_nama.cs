using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SecondHandShop1.Models
{
    public class O_nama
    {
        [Required]
        [Key]
        public int ido_nama { get; set; }
    }
}