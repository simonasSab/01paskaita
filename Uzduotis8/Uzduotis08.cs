// See https://aka.ms/new-console-template for more information

namespace Paskaita01
{
    public class Uzduotis08
    {
        // Naudokite funkcija new Random(). Sukurkite tris kintamuosius su atsitiktinėm reikšmėm nuo 0 iki 100.
        // Paskaičiuokite jų aritmetinį vidurkį.
        // Ir aritmetinį vidurkį atmetus tas reikšmes, kurios yra mažesnės nei 10 arba didesnės nei 90.
        // Abu vidurkius atspausdinkite. Rezultatus apvalinkite iki sveiko skaičiaus.
        public static void Main(String[] args)
        {
            Random random = new Random();

            int a = random.Next(0, 101);
            int a2;
            if (a > 9 || a < 89)
                a2 = a;
            else
                a2 = 0;

            int b = random.Next(0, 101);
            int b2;
            if (b > 9 || b < 89)
                b2 = b;
            else
                b2 = 0;

            int c = random.Next(0, 101);
            int c2;
            if (c > 9 || c < 89)
                c2 = c;
            else
                c2 = 0;

            float averageAll = ((float)a + (float)b + (float)c) / 3;
            float averageCapped = ((float)a2 + (float)b2 + (float)c2) / 3;

            Console.WriteLine($"Bendras vidurkis: {averageAll:.}\nVidurkis atmetus [0;9] ir [91;100]: {averageCapped:.}");
        }
    }
}
