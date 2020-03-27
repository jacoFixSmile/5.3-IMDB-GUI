using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_IMDB___GUI
{
    class Serie : Media
    {
        public int AantalSeizoenen { get; set; }

        private List<Acteurs> ListActeurs { get; set; }

        public Serie(string titel, double rating, int aantalSeizoenen)
            : base(titel, rating)
        {
            AantalSeizoenen = aantalSeizoenen;
            ListActeurs = new List<Acteurs>();
        }
        public Serie(string titel, int aantalSeizoenen)
    : base(titel)
        {
            AantalSeizoenen = aantalSeizoenen;
            ListActeurs = new List<Acteurs>();
        }
        public void AddActeur(Acteurs acteur)
        {
            ListActeurs.Add(acteur);
        }
        public override string ToString()
        {
            string terug = base.ToString() + "\nAantal Seizoenen: " + AantalSeizoenen + "\nActeurs:";
            for (int i = 0; i < ListActeurs.Count; i++)
            {
                terug += "\n" + (i + 1) + " " + ListActeurs[i];
            }
            return terug;
        }
    }
}
