namespace Paskaita01
{
    public class Uzduotis10
    {
        // Naudokite funkcija new Random(). Sugeneruokite 6 kintamuosius su atsitiktinem reikšmėm nuo 1000 iki 9999.
        // Atspausdinkite reikšmes viename stringe, išrūšiuotas nuo didžiausios iki mažiausios, atskirtas tarpais. Naudoti ciklų ir masyvų NEGALIMA.
        public static void Main(String[] args)
        {
            Random rand = new Random();

            int a = rand.Next(1000, 10000);
            int b = rand.Next(1000, 10000);
            int c = rand.Next(1000, 10000);
            int d = rand.Next(1000, 10000);
            int e = rand.Next(1000, 10000);
            int f = rand.Next(1000, 10000);
            int temp;

            // Set 1st number
            if (b > a) { temp = b; b = a; a = temp; }
            if (c > a) { temp = c; c = a; a = temp; }
            if (d > a) { temp = d; d = a; a = temp; }
            if (e > a) { temp = e; e = a; a = temp; }
            if (f > a) { temp = f; f = a; a = temp; }
            // Set 2nd number
            if (c > b) { temp = c; c = b; b = temp; }
            if (d > b) { temp = d; d = b; b = temp; }
            if (e > b) { temp = e; e = b; b = temp; }
            if (f > b) { temp = f; f = b; b = temp; }
            // Set 3rd number
            if (d > c) { temp = d; d = c; c = temp; }
            if (e > c) { temp = e; e = c; c = temp; }
            if (f > c) { temp = f; f = c; c = temp; }
            // Set 4th number
            if (e > d) { temp = e; e = d; d = temp; }
            if (f > d) { temp = f; f = d; d = temp; }
            // Set 5th and 6th numbers
            if (f > e) { temp = f; f = e; e = temp; }

            Console.WriteLine($"{a} {b} {c} {d} {e} {f}");
        }
    }
}
