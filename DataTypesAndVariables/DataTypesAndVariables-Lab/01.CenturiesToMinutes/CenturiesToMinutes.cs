using System; 

namespace _01.CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main()
        {
            byte century = byte.Parse(Console.ReadLine());
            byte oneHundred = 100;
            short years = (short)(century * oneHundred);
            int days = (int)(years * 365.2425);
            long hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine(century);
            Console.WriteLine(years);
            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
        }
    }
}
