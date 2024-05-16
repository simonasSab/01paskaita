// See https://aka.ms/new-console-template for more information

namespace PirmaPaskaita
{
    public class Uzduotis02
    {
        // Sukurkite du kintamuosius ir naudodamiesi funkcija new Random() jiems priskirkite atsitiktines reikšmes nuo 0 iki 4.
        // Didesnę reikšmę padalinkite iš mažesnės. Atspausdinkite rezultatą jį suapvalinę iki 2 skaičių po kablelio.
        public static void Main(String[] args)
        {
            Random rand = new Random();
            int a = rand.Next(0, 5);
            int b = rand.Next(0, 5);

            if (a == 0 || b == 0)
            {
                Console.WriteLine("Bent vienas iš skaičių lygus 0 - dalyba negalima");
                return;
            }
            else
            {
                float div = (float)a / (float)b;
            }

            if (a > b)
                Console.WriteLine($"Dalmuo: {a / b:.00}");
            else if (b > a)
                Console.WriteLine($"Dalmuo: {b / a:.00}");
            else
                Console.WriteLine("Skaičiai lygūs. Dalmuo: 1.00");
        }
    }
}
