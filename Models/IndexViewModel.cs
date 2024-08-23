
using MySql.Data.EntityFramework;
using SecondHandShop1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SecondHandShop1.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Odjeca> Odjeca { get; set; }
        public IEnumerable<Nakit> Nakit { get; set; }
        public IEnumerable<Obuca> Obuca { get; set; }
        public IEnumerable<O_nama> O_nama { get; set; }

        public IEnumerable<Kontakt> Kontakt { get; set; }

        public bool IsAdmin { get; set; }
    }
}
