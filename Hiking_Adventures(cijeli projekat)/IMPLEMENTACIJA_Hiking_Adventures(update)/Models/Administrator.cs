using System;

namespace Hiking_Adventures.Models
{
    public class Administrator: Osoba
    {
        public Administrator(string imeKorisnika, string prezimeKorisnika, string eMailKorisnika, 
            string usernameKorisnika, string passwordKorisnika): 
            base(imeKorisnika, prezimeKorisnika, eMailKorisnika, usernameKorisnika, passwordKorisnika)
          
    }
}
