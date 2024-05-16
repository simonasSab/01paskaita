// See https://aka.ms/new-console-template for more information
using System;

namespace Paskaita01
{
    public class Uzduotis002_03
    {
        public static void Main(String[] args)
        {
            //Užduotis 3: Amžiaus skaičiavimas
            //Sukurkite programą, kuri paprašytų vartotojo įvesti savo gimimo metus ir apskaičiuotų bei atspausdintų vartotojo amžių.

            ///////////// Per ilgai uztrunka kol kas ///////////////////////////////////////
            //Console.WriteLine("Sveiki, parasykite formatu MMMM-mm-dd savo gimimo diena ");
            //DateOnly.TryParse(Console.ReadLine(), out DateOnly date);

            //DateOnly siandiena = DateOnly.Parse(DateTime.Today);
            ////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Sveiki, parasykite savo gimimo metus ");
            int.TryParse(Console.ReadLine(), out int gimimoMetai);
            Console.WriteLine($"Jums yra {2024 - gimimoMetai} metai/-u");
        }
    }
}
