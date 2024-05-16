// See https://aka.ms/new-console-template for more information

namespace PirmaPaskaita
{
    public class Uzduotis1
    {
        // Įvedami skaičiai - a, b, c – kraštinių ilgiai, trys kintamieji (naudojame int) (naudokite new Random() funkcija nuo 1 iki 10).
        // Parašykite C# programą, kuri nustatytų, ar galima sudaryti trikampį ir atsakymą atspausdintų.
        public static void Main(String[] args)
        {
            Random rand = new Random();

            int a = rand.Next(1, 10);
            int b = rand.Next(1, 10);
            int c = rand.Next(1, 10);

            if (a + b > c && b + c > a && a + c > b)
                Console.WriteLine($"GALIMA sudaryti trikampį su kraštinėmis {a}, {b} ir {c}");
            else
                Console.WriteLine($"NEGALIMA sudaryti trikampio su kraštinėmis {a}, {b} ir {c}");
        }
    }
}
