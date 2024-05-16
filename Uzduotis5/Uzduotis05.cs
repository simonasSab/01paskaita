// See https://aka.ms/new-console-template for more information

namespace PirmaPaskaita
{
    public class Uzduotis05
    {
        // Sukurkite keturis kintamuosius ir new Random() funkcija sugeneruokite jiems reikšmes nuo 0 iki 2.
        // Suskaičiuokite kiek yra nulių, vienetų ir dvejetų. (sprendimui masyvo nenaudoti).
        public static void Main(String[] args)
        {
            Random rand = new Random();

            int nuliai = 0;
            int vienetai = 0;
            int dvejetai = 0;

            int a = rand.Next(0, 3);
            switch (a)
            {
                case 0:
                    nuliai++;
                    break;
                case 1:
                    vienetai++;
                    break;
                case 2:
                    dvejetai++;
                    break;
            }

            int b = rand.Next(0, 3);
            switch (b)
            {
                case 0:
                    nuliai++;
                    break;
                case 1:
                    vienetai++;
                    break;
                case 2:
                    dvejetai++;
                    break;
            }

            int c = rand.Next(0, 3);
            switch (c)
            {
                case 0:
                    nuliai++;
                    break;
                case 1:
                    vienetai++;
                    break;
                case 2:
                    dvejetai++;
                    break;
            }

            int d = rand.Next(0, 3);
            switch (d)
            {
                case 0:
                    nuliai++;
                    break;
                case 1:
                    vienetai++;
                    break;
                case 2:
                    dvejetai++;
                    break;
            }

            Console.WriteLine($"Nulių: {nuliai}\nVienetų: {vienetai}\nDvejetų: {dvejetai}");
        }
    }
}
