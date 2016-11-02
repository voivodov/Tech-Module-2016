using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var dateAsText = Console.ReadLine();
            var date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
