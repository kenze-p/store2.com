using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Prodavnica.Klase
{
    internal class Artikal
    {
        public int id { get; set; }
        public int cena { get; set; }
        public string mera { get; set; }
        public string naziv { get; set; }
        public int idKategorije { get; set; }
        public Artikal(int id, string naziv, int idKategorije, int cena, string mera)
        {
            this.id = id;
            this.cena = cena;
            this.mera = mera;
            this.naziv = naziv;
            this.idKategorije = idKategorije;
        }

    }
}
