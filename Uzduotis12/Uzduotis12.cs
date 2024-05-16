// See https://aka.ms/new-console-template for more information

namespace PirmaPaskaita
{
    public class Uzduotis12
    {
        // Įvestų duomenų tipo atpažinimas. Sukurkite programą, kuri atskirtų kokio tipo t.y (int, string) (tik šių 2) tipo reikšmė buvo įvesta.
        // Jeigu tai int kintamasis tai jį reikia padauginti iš 11 ir atvaizduoti ekrane.
        // Jeigu tai string tipo kintamasis reikia prieš jį pridėti # ir po jo pridėti # ir atvaizduoti naują reikšmę ekrane
        public static void Main(String[] args)
        {
            string input;
            bool isInt = false;

            // Get input
            do
            {
                Console.WriteLine("Įrašykite ką nors: ");
                input = Console.ReadLine();
            }
            while (input == null);

            // Try to convert to int
            isInt = int.TryParse(input, out int integer);

            if (isInt)
                Console.WriteLine($"{integer * 11}");
            else
                Console.WriteLine($"#{input}#");
        }
    }
}
