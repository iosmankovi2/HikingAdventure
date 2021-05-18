using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hiking_Adventure.Models
{
    public class Ruta
    {
        public int ID { get; set; }

        public string tezina;
        public string nazivRute { get; set; }
        public string Opis { get; }


        //Konstruktor
        public Ruta() { }
        public Ruta(int id, string naziv, string opis)
        {
            ID = id;
            nazivRute = naziv;
            Opis = opis;

        }


    }
}
