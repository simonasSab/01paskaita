// See https://aka.ms/new-console-template for more information

namespace Paskaita01
{
    public class Uzduotis06
    {
        // Naudokite funkcija new Random().
        // Sukurkite ir atspausdinkite 3 skaičius nuo -10 iki 10.
        // Skaičiai mažesni už 0 turi būti  laužtiniuose skliaustuose [], 0 -  (), didesni už 0 {}.
        public static void Main(String[] args)
        {
            Random rand = new Random();

            string aText;
            string bText;
            string cText;

            int a = rand.Next(-10, 11);
            switch (a)
            {
                case < 0:
                    aText = "[" + a + "]";
                    break;
                case 0:
                    aText = "(" + a + ")";
                    break;
                case > 0:
                    aText = "{" + a + "}";
                    break;
            }

            int b = rand.Next(-10, 11);
            switch (b)
            {
                case < 0:
                    bText = "[" + b + "]";
                    break;
                case 0:
                    bText = "(" + b + ")";
                    break;
                case > 0:
                    bText = "{" + b + "}";
                    break;
            }

            int c = rand.Next(-10, 11);
            switch (c)
            {
                case < 0:
                    cText = "[" + c + "]";
                    break;
                case 0:
                    cText = "(" + c + ")";
                    break;
                case > 0:
                    cText = "{" + c + "}";
                    break;
            }

            Console.WriteLine($"Pirmas skaičius: {aText}\nAntras skaičius: {bText}\nTrečias skaičius: {cText}");
        }
    }
}
