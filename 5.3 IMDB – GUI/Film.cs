using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_IMDB___GUI
{
    class Film : Media
    {
        public string Producer { get; set; }
        public string Regisseur { get; set; }
        public string Genre { get; set; }
        public DateTime Uitgaven { get; set; }
        // film met scoer
        public Film(string titel, double score, string producer, string regisseur, string genre, DateTime uitgaven)
            : base(titel, score)
        {
            Producer = producer;
            Regisseur = regisseur;
            Genre = genre;
            Uitgaven = uitgaven;
        }
        // film zonder score
        public Film(string titel, string producer, string regisseur, string genre, DateTime uitgaven)
        : base(titel)
        {
            Producer = producer;
            Regisseur = regisseur;
            Genre = genre;
            Uitgaven = uitgaven;
        }
        public override string ToString()
        {
            return base.ToString() + "\nProducer: " + Producer + "\nRegisseur: " + Regisseur + "\nGenre: " + Genre + "\nUitgaven: " + Uitgaven.ToShortDateString();
        }
    }
}
