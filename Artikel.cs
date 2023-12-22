using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Artikelverwaltung
{
    internal class Artikel
    {
        // Attribute
        public string Name { get; set; }
        public double Price { get; set; }

        // Konstruktor
        public Artikel(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        // toString Methode überseteuern
        public override string ToString()
        {
            return $"Name: {Name} Price: {Price}";
        }
    }
}
