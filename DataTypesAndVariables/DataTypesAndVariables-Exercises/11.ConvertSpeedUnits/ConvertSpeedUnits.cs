using System; 

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int metric = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());            
            int minutes = int.Parse(Console.ReadLine());           
            int secunds = int.Parse(Console.ReadLine());
            

            float totalTimeMinut = (hours*60.0F) + minutes + (secunds / 60.0F);

            float metricPerSecond = metric / (totalTimeMinut * 60.0F);

            float kilometersPerHour = (metric / 1000.0F) / (totalTimeMinut / 60.0F);

            float milesPerHour = (metric / 1609.0F) / (totalTimeMinut / 60.0F);

            Console.WriteLine("{0}", metricPerSecond);
            Console.WriteLine("{0}", kilometersPerHour);
            Console.WriteLine("{0}", milesPerHour);
        }
    }
}
