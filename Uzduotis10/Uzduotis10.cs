// See https://aka.ms/new-console-template for more information

namespace PirmaPaskaita
{
    public class Uzduotis10
    {
        // Naudokite funkcija new Random(). Sugeneruokite 6 kintamuosius su atsitiktinem reikšmėm nuo 1000 iki 9999.
        // Atspausdinkite reikšmes viename stringe, išrūšiuotas nuo didžiausios iki mažiausios, atskirtas tarpais. Naudoti ciklų ir masyvų NEGALIMA.
        public static void Main(String[] args)
        {
            Random rand = new Random();

            int a = rand.Next(1000, 10000);
            int b = rand.Next(1000, 10000);
            int c = rand.Next(1000, 10000);
            int d = rand.Next(1000, 10000);
            int e = rand.Next(1000, 10000);
            int f = rand.Next(1000, 10000);

            // TO DO ...

            //int x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0;

            //if (a > b && a > c && a > d && a > e && a > f)
            //{
            //    x1 = a;
            //    // DONE: x2 = b;
            //    if (b > c && b > d && b > e && b > f)
            //    {
            //        x2 = b;
            //        if (c > d && c > e && c > f)
            //        {
            //            x3 = c;
            //            if (d > e && d > f)
            //            {
            //                x4 = d;
            //                if (e > f)
            //                {
            //                    x5 = e;
            //                    x6 = f;
            //                }
            //                else if (f > e)
            //                {
            //                    x5 = f;
            //                    x6 = e;
            //                }
            //            }
            //            else if (e > d && e > f)
            //            {
            //                x4 = e;
            //                if (d > f)
            //                {
            //                    x5 = d;
            //                    x6 = f;
            //                }
            //                else if (f > d)
            //                {
            //                    x5 = f;
            //                    x6 = d;
            //                }
            //            }
            //            else if (f > d && f > e)
            //            {
            //                x4 = f;
            //                if (d > e)
            //                {
            //                    x5 = d;
            //                    x6 = e;
            //                }
            //                else if (e > d)
            //                {
            //                    x5 = e;
            //                    x6 = d;
            //                }
            //            }
            //        }
            //        else if (d > c && d > e && d > f)
            //        {
            //            x3 = d;
            //            if (c > e && c > f)
            //            {
            //                x4 = c;
            //                if (e > f)
            //                {
            //                    x5 = e;
            //                    x6 = f;
            //                }
            //                else if (f > e)
            //                {
            //                    x5 = f;
            //                    x6 = e;
            //                }
            //            }
            //            else if (e > d && e > f)
            //            {
            //                x4 = e;
            //                if (c > f)
            //                {
            //                    x5 = c;
            //                    x6 = f;
            //                }
            //                else if (f > c)
            //                {
            //                    x5 = f;
            //                    x6 = c;
            //                }
            //            }
            //            else if (f > d && f > e)
            //            {
            //                x4 = f;
            //                if (c > e)
            //                {
            //                    x5 = c;
            //                    x6 = e;
            //                }
            //                else if (e > c)
            //                {
            //                    x5 = e;
            //                    x6 = c;
            //                }
            //            }
            //        }
            //        else if (e > d && e > c && e > f)
            //        {
            //            x3 = e;
            //            if (c > d && c > f)
            //            {
            //                x4 = c;
            //                if (d > f)
            //                {
            //                    x5 = d;
            //                    x6 = f;
            //                }
            //                else if (f > d)
            //                {
            //                    x5 = f;
            //                    x6 = d;
            //                }
            //            }
            //            else if (d > c && d > f)
            //            {
            //                x4 = d;
            //                if (c > f)
            //                {
            //                    x5 = c;
            //                    x6 = f;
            //                }
            //                else if (f > c)
            //                {
            //                    x5 = f;
            //                    x6 = c;
            //                }
            //            }
            //            else if (f > d && f > c)
            //            {
            //                x4 = f;
            //                if (c > f)
            //                {
            //                    x5 = c;
            //                    x6 = f;
            //                }
            //                else if (f > c)
            //                {
            //                    x5 = f;
            //                    x6 = c;
            //                }
            //            }
            //        }
            //        else if (f > d && f > e && f > c)
            //        {
            //            x3 = f;
            //            if (c > d && c > e)
            //            {
            //                x4 = c;
            //                if (d > e)
            //                {
            //                    x5 = d;
            //                    x6 = e;
            //                }
            //                else if (e > d)
            //                {
            //                    x5 = e;
            //                    x6 = d;
            //                }
            //            }
            //            else if (d > c && d > e)
            //            {
            //                x4 = d;
            //                if (c > e)
            //                {
            //                    x5 = c;
            //                    x6 = e;
            //                }
            //                else if (e > c)
            //                {
            //                    x5 = e;
            //                    x6 = c;
            //                }
            //            }
            //            else if (e > d && e > c)
            //            {
            //                x4 = e;
            //                if (c > d)
            //                {
            //                    x5 = c;
            //                    x6 = d;
            //                }
            //                else if (d > c)
            //                {
            //                    x5 = d;
            //                    x6 = c;
            //                }
            //            }
            //        }
            //    }
            //    else if (c > b && c > d && c > e && c > f)
            //        x2 = c;
            //    // TO DO
            //    else if (d > b && d > c && d > e && d > f)
            //        x2 = d;
            //    // TO DO
            //    else if (e > b && e > c && e > d && e > f)
            //        x2 = e;
            //    // TO DO
            //    else if (f > b && f > c && f > d && f > e)
            //        x2 = f;
            //    // TO DO
            //}
            //else if (b > a && b > c && b > d && b > e && b > f)
            //{
            //    x1 = b;
            //    // TO DO
            //}
            //else if (c > a && c > b && c > d && c > e && c > f)
            //{
            //    x1 = c;
            //    // TO DO
            //}
            //else if (d > a && d > c && d > b && d > e && d > f)
            //{
            //    x1 = d;
            //    // TO DO
            //}
            //else if (e > a && e > c && e > d && e > b && e > f)
            //{
            //    x1 = e;
            //    // TO DO
            //}
            //else if (f > a && f > c && f > d && f > e && f > b)
            //{
            //    x1 = f;
            //    // TO DO
            //}
        }
    }
}
