using System; 

namespace _01.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday", };
            int dayNumber = int.Parse(Console.ReadLine());
            if (dayNumber <= 7 && dayNumber >= 1)
            {
                Console.WriteLine(days[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
