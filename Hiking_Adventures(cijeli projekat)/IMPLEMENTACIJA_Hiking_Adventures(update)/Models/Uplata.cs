using System;

namespace Hiking_Adventure.Models
{
    public class Uplata
    {
        public string ime { get; set }
        public string prezime { get; set }
        public string email { get; set }
        public string username { get; set }
        public string password { get; set }
        public DateTime Datum { get; set; }
        public int brojBankovnogRacuna { get; set }
        public Ruta ruta { get; set }
        public double cijenaRute { get; set }

        public void izvrsiUplatu(double cijena)
        {
            cijenaRute = cijena;
        }
    }
}
