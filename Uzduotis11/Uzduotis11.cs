// See https://aka.ms/new-console-template for more information

namespace Paskaita01
{
    public class Uzduotis11
    {
        // Savaitės dienų atvaizdavimas.
        // Sukurkite programą, kuri paprašytų vartotojo įvesti savaitės dienos numerį (1 iki 7)
        // ir pagal tai atspausdintų dienos pavadinimą naudojant switch sakinį.
        public static void Main(String[] args)
        {
            int weekDay = 0;

            do
            {
                Console.WriteLine("Parašykite savaitės dienos numerį nuo 1 iki 7: ");
                int.TryParse(Console.ReadLine(), out weekDay);
            }
            while (weekDay < 1 || weekDay > 7);

            switch (weekDay)
            {
                case 1:
                    Console.WriteLine("Pirmadienis");
                    break;
                case 2:
                    Console.WriteLine("Antradienis");
                    break;
                case 3:
                    Console.WriteLine("Trečiadienis");
                    break;
                case 4:
                    Console.WriteLine("Ketvirtadienis");
                    break;
                case 5:
                    Console.WriteLine("Penktadienis");
                    break;
                case 6:
                    Console.WriteLine("Šeštadienis");
                    break;
                case 7:
                    Console.WriteLine("Sekmadienis");
                    break;
            }
        }
    }
}
