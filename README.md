# Projektname

Das Projekt ist eine .Net Konsolenanwendung, welche Artikel in der Konsole ausgibt.

## Klassen

### Artikel

Die Klasse Artkel befindet sich in der Datei 'Artikel.cs'

```C#
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
```


## Program.cs

* Im Main Teil wird zuerst ein Tuple / Dictonary erstell mit Produkten.
* Diese werden dann durch eine foreach Schleife in eine Artikel Liste interiert.
* Als letztes werden die Artikel durch eine foreach Schleife mit der ToString() Methode ausgegeben.

```C#
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
```