using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiking_Adventures.Models
    public class Komentar
    {
        public int KomentarId { get; set; }
        public string tekstKomentara { get; set; }

        //dio u kojem se definisu veze sa ostalim klasama
        public virtual Vodic Vodic { get; set; }
        public virtual RegistrovaniKorisnik RegistrovaniKorisnik { get; set; }

    }
}
