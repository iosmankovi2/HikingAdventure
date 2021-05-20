using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiking_Adventures.Models
{
    public class PrijavaRute
    {
        public int ID { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime Datum{ get; set; }

        public string eMail { get; set; }

        public string NaziRute { get; set; }

        //Konstruktor
        public PrijavaRute() { }
        public PrijavaRute(int id, string ime, string prezime, DateTime datum, string mail)
        {
            ID = id;
            Ime = ime;
            Prezime = Prezime;
            Datum = datum;
            eMail = mail;
            

        }
    }
}
