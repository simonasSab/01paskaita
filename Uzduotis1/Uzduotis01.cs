// See https://aka.ms/new-console-template for more information

namespace Paskaita01
{
    public class Uzduotis01
    {
        // Sukurkite 4 kintamuosius, kurie saugotų jūsų vardą, pavardę, gimimo metus ir šiuos metus (nebūtinai tikrus).
        // Parašykite kodą, kuris pagal gimimo metus paskaičiuotų jūsų amžių ir naudodamas vardo ir pavardės kintamuosius atspausdintų tokį sakinį:
        // "Aš esu Vardenis Pavardenis. Man yra XX metai(ų)".
        public static void Main(String[] args)
        {
            string name = "Benas";
            string surname = "Nidauskas";
            int birthYear = 1992;
            int currentYear = 2024;

            int age = currentYear - birthYear;

            Console.WriteLine($"Aš esu {name} {surname}. Man yra {age} metai(ų)");
        }
    }
}
