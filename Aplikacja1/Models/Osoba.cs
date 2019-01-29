using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplikacja1.Models
{
    public class Osoba
    {
        [Key]
        [Required]
        public int OsobaId { get; set; }
        
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Telefon { get; set; }

    }
}