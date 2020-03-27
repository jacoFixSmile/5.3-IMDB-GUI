using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_IMDB___GUI
{
    class Media
    {
        private const int HOOGSTE = 5, LAAGSTE = 1;
        public string Titel { get; set; }
        public double Rating { get; set; }
        public List<double> ListRating { get; set; }
        // constructor groot met alle velden
        public Media(string titel, double rating)
        {
            Titel = titel;
            ListRating = new List<double>();
            Addscore(rating);
        }
        // geen score opgegeven
        public Media(string titel) : this(titel, 2.5)
        {

        }
        public void Addscore(double score)
        {
            if (score <= HOOGSTE && score >= LAAGSTE)
            {
                ListRating.Add(score);
                double som = 0;
                for (int i = 0; i < ListRating.Count; i++)
                {
                    som += ListRating[i];
                }
                Rating = som / ListRating.Count;

            }
            else
            {
                Console.WriteLine(Titel);
                throw new Exception("Score ligt niet tussen het berijk van " + LAAGSTE + " en " + HOOGSTE);
            }
        }
        private void BerekenRating()
        {
            double som = 0;
            for (int i = 0; i < ListRating.Count; i++)
            {
                if (ListRating[i] != HOOGSTE || ListRating[i] != LAAGSTE)
                {
                    som += ListRating[i];
                }
            }
            Rating = som / ListRating.Count;


        }
        public override string ToString()
        {
            return Titel + " score:" + Rating + "/5";
        }
    }
}
