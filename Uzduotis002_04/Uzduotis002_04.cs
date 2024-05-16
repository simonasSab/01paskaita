// See https://aka.ms/new-console-template for more information
using System;

namespace Paskaita01
{
    public class Uzduotis002_04
    {
        public static void Main(String[] args)
        {
            //Užduotis 4: Temperatūros konversija
            //Sukurkite programą, kuri leistų vartotojui įvesti temperatūrą Farenheito skalėje ir paskaičiuotų bei atspausdintų temperatūrą Celsijaus skalėje.

            // Formule:     C = (F – 32) *5 / 9

            Console.WriteLine("Iveskite laipsnius Farenheito skaleje... ");

            float.TryParse(Console.ReadLine(), out float farenheit);

            float celsius = (farenheit - 32f) * 5f / 9f;

            Console.WriteLine("Temperatura laipsniais Celsijaus skaleje: " + celsius);
        }
    }
}
