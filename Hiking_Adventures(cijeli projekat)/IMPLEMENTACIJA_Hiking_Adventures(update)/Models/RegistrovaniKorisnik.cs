using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiking_Adventures.Models

public class RegistrovaniKorisnik: Osoba
{
	public int RegistrovaniKorisnikId { get; set; }
	public int brojBankovnogRacuna { get; set; };
	public Ruta ruta { get; set; }
	public Uplata uplata { get; set; }

	public virtual Ruta Ruta { get; set; }
	public virtual Uplata Uplata { get: set;  }

}
