// See https://aka.ms/new-console-template for more information
using System;

namespace Paskaita01
{
    public class Uzduotis002_02
    {
        public static void Main(String[] args)
        {
            //Užduotis 2: Aritmetinės operacijos
            //Sukurkite programą, kuri leistų vartotojui įvesti du skaičius ir atspausdintų jų sumą, skirtumą, sandaugą ir dalmenį.

            Console.WriteLine("Iveskite PIRMAJI bet koki skaiciu: ");
            float.TryParse(Console.ReadLine(), out var pirmasSkaicius);
            Console.WriteLine("Iveskite ANTRAJI bet koki skaiciu: ");
            float.TryParse(Console.ReadLine(), out var antrasSkaicius);

            float suma = pirmasSkaicius + antrasSkaicius;
            float skirtumas = pirmasSkaicius - antrasSkaicius;
            float sandauga = pirmasSkaicius * antrasSkaicius;
            float dalmuo = pirmasSkaicius / antrasSkaicius;

            Console.Write($"Skaiciu {pirmasSkaicius} ir {antrasSkaicius}...\nSuma: {suma}\nSkirtumas: {skirtumas}\nSandauga: {sandauga}\nDalmuo: {dalmuo}\n");
        }
    }
}
