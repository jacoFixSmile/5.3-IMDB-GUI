using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_IMDB___GUI
{
    class Acteurs
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }

        public Acteurs(string naam, string voornaam)
        {
            Naam = naam;
            Voornaam = voornaam;
        }
        public override string ToString()
        {
            return "Acteur. naam: " + Voornaam + " Achternaam: " + Naam;
        }
    }
}
