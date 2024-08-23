
using MySql.Data.EntityFramework;
using SecondHandShop1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Secondhandshop1.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BazaDbContext : DbContext
    { 
        public DbSet<Odjeca> Odjeca { get; set; }

        public DbSet<Nakit> Nakit { get; set; }

        
        public DbSet<Obuca> Obuca { get; set; }


        public DbSet<Korisnik> Korisnik { get; set; }

        public DbSet<O_nama> O_nama { get; set; }

        public DbSet<Kontakt> Kontakt { get; set; }

      


    }
}