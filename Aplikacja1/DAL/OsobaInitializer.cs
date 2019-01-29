using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aplikacja1.Models;
using System.Data.Entity;

namespace Aplikacja1.DAL
{
    public class OsobaInitializer : DropCreateDatabaseIfModelChanges<OsobaContext>
    {
        protected override void Seed(OsobaContext context)
        {
            var osoba = new List<Osoba>
            {
                new Osoba{Imie="Jan",Nazwisko="Jankowski",Telefon=1234},
                new Osoba{Imie="qwer",Nazwisko="qwe",Telefon=1234}
            };
            osoba.ForEach(s => context.Osobas.Add(s));
            context.SaveChanges();
        }
    }
}