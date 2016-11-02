using System; 

namespace _19.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long ft = long.Parse(Console.ReadLine());
            long ff = long.Parse(Console.ReadLine());
            long ut = long.Parse(Console.ReadLine());

            double percentage = (ff / 100.00);
            double useful = Math.Ceiling(n * percentage);
            double alltimeneeded = (n * ft) + (useful * ut);
            TimeSpan t = TimeSpan.FromSeconds(alltimeneeded);
            string answer = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}", t.Days, t.Hours, t.Minutes, t.Seconds);
            Console.WriteLine(answer);

        }
    }
}
