using System;
using System.Collections.Generic;

namespace Artikelverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tuple Liste mit Daten
            List<(string, double)> artikelTuple = new List<(string, double)>
            {
                ("Produkt 1", 9.99),
                ("Produkt 2", 8.88),
                ("Produkt 3", 7.77),
                ("Produkt 4", 6.66),
                ("Produkt 5", 5.55)
            };

            // Artikel Liste
            List<Artikel> artikel = new List<Artikel>();

            // Iteration durch ArtikelT in Artikel
            foreach ((string, double) product in artikelTuple)
            {
                artikel.Add(new Artikel(product.Item1, product.Item2));
            }

            // Iteration durch Artikel für Ausgabe
            foreach(Artikel product in artikel)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
