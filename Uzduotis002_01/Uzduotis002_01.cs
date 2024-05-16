// See https://aka.ms/new-console-template for more information
using System;

namespace PirmaPaskaita
{
    public class Uzduotis002_01
    {
        public static void Main(String[] args)
        {
            //Užduotis 1: Sveikinimo programa
            //Sukurkite programą, kuri paprašytų vartotojo įvesti savo vardą ir po to pasveikintų jį išvedant tekstą į konsolę.

            Console.Write("Koks Jusu vardas? ");
            string name = Console.ReadLine();
            Console.WriteLine($"\nSveiki atvyke, {name}!");
        }
    }
}
