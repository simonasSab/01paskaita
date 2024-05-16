// See https://aka.ms/new-console-template for more information

namespace PirmaPaskaita
{
    public class Uzduotis09
    {
        // Padarykite skaitmeninį laikrodį, rodantį valandas, minutes ir sekundes.
        // Valandom, minutėm ir sekundėm sugeneruoti panaudokite funkciją new Random().
        // Sugeneruokite skaičių nuo 0 iki 300. Tai papildomos sekundės.
        // Skaičių pridėkite prie jau sugeneruoto laiko. Atspausdinkite laikrodį prieš ir po sekundžių pridėjimo ir pridedamų sekundžių skaičių.
        public static void Main(String[] args)
        {
            Random random = new Random();

            int hours = random.Next(0, 24);
            int minutes = random.Next(0, 60);
            int seconds = random.Next(0, 60);
            int extraHours = 0;

            string displayedTime = $"{hours:00}:{minutes:00}:{seconds:00}";
            Console.WriteLine(displayedTime);

            int extraSeconds = random.Next(0, 301);
            seconds += extraSeconds;

            int extraMinutes = seconds / 60;
            seconds %= 60;
            minutes += extraMinutes;
            extraHours %= minutes;
            hours += extraHours;

            displayedTime = $"{hours:00}:{minutes:00}:{seconds:00}";
            Console.WriteLine(displayedTime + " (Added " + extraSeconds + " seconds)");
        }
    }
}
