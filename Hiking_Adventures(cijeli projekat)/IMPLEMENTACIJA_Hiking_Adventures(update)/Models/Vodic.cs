using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiking_Adventures.Models

public class Vodic
{
	public int VodicId { get; set; }
	public int List<Ocjena> ocjene;
	public string List<Komentar> komentari;
	public Ruta mojaRuta {get; set;}

	public virtual Osoba Osoba { get; set; }
	
}
