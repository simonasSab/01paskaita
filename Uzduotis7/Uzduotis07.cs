// See https://aka.ms/new-console-template for more information

namespace Paskaita01
{
    public class Uzduotis07
    {
        // Įmonė parduoda žvakes po 1 EUR.
        // Perkant daugiau kaip 1000 vienetų taikoma 3 % nuolaida, daugiau kaip 2000 vienetų - 4 % nuolaida.
        // Parašykite programą, kuri skaičiuos žvakių kainą ir atspausdintų atsakymą kiek žvakių ir kokia kaina perkama.
        // Žvakių kiekį generuokite new Random() funkcija nuo 5 iki 3000.
        public static void Main(String[] args)
        {
            Random rand = new Random();

            int candleAmount = rand.Next(5, 3000);
            float candlePrice;

            switch (candleAmount)
            {
                case < 1001:
                    candlePrice = 1f;
                    break;
                case < 2001:
                    candlePrice = 0.97f;
                    break;
                case > 2000:
                    candlePrice = 0.96f;
                    break;
            }

            Console.WriteLine($"Perkama {candleAmount} žvakių(-ės) po {candlePrice:0.00} EUR.");
        }
    }
}
