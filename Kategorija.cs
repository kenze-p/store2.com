using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prodavnica.Klase
{
    internal class Kategorija
    {
        private int id { get; set; }
        private string ime { get; set; }
        public Kategorija(int id, string ime)
        {
            this.id = id;
            this.ime = ime;
        }
    }
}
