using System; 

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            double peopleCount = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            double result = Math.Ceiling(peopleCount / capacity);
            Console.WriteLine(result);
        }
    }
}
