// See https://aka.ms/new-console-template for more information

namespace PirmaPaskaita
{
    public class Uzduotis03
    {
        // Naudokite funkcija new Random().
        // Sukurkite tris kintamuosius ir naudodamiesi funkcija new Random() jiems priskirkite atsitiktines reikšmes nuo 0 iki 25.
        // Raskite ir atspausdinkite kintąmąjį turintį vidurinę reikšmę.
        public static void Main(String[] args)
        {
            Random rand = new Random();

            int a = rand.Next(0, 26);
            int b = rand.Next(0, 26);
            int c = rand.Next(0, 26);

            float average = ((float)a + (float)b + (float)c) / 3;

            if (a == b && b == c)
                Console.WriteLine("Visi kintamieji lygūs " + a);
            else if (a == b || a == c)
                Console.WriteLine($"Nėra vieno vidurinio kintamojo, nes du vienodi kintamieji lygūs {a}\nBendras aritmetinis vidurkis: {average:.00}");
            else if (b == c)
                Console.WriteLine($"Nėra vieno vidurinio kintamojo, nes du vienodi kintamieji lygūs {b}\nBendras aritmetinis vidurkis: {average:.00}");
            else if ((a < b && a > c) || (a < c && a > b))
                Console.WriteLine("Vidurinis kintamasis: " + a);
            else if ((b < c && b > a) || (b < a && b > c))
                Console.WriteLine("Vidurinis kintamasis: " + b);
            else if ((c < b && c > a) || (c < a && c > b))
                Console.WriteLine("Vidurinis kintamasis: " + c);
        }
    }
}
