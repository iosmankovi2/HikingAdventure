using System;


namespace Hiking_Adventures.Models {
	public abstract class Osoba
	{
		public string ime { get; set }
		public string prezime { get; set }
		public string email { get; set }
		public string username { get; set }
		public string password { get; set }


		public Osoba()
        {

        }

		public Osoba(string imeKorisnika, string prezimeKorisnika, string eMailKorisnika,
			string usernameKorisnika, string passwordKorisnika)
        {
			ime = imeKorisnika;
			prezime = prezimeKorisnika;
			email = eMailKorisnika;
			username = usernameKorisnika;
			password = passwordKorisnika;
        }

	}


}
	
