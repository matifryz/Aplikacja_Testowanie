using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aplikacja1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Aplikacja1.DAL
{
    public class OsobaContext :DbContext
    {
        public OsobaContext() : base("OsobaContext")
        {

        }
        public DbSet<Osoba> Osobas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}