using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwm
{
    public class Film
    {
        public string Nazwa { get; set; }

        public int Ocena { get; set; }

        public string Opis { get; set; }

        public string Gatunek { get; set; }

        public bool Oglodany { get; set; }

        public Film(string nazwa, int ocena, string opis, string gatunek)
        {
            Nazwa = nazwa;
            Ocena = ocena;
            Opis = opis;
            Gatunek = gatunek;
            Oglodany = false;
        }
    }
}
