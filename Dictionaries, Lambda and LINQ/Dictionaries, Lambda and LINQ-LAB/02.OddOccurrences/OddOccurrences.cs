using System;
using System.Linq;

namespace _02.OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var word = text.Split();

            Console.WriteLine(String.Join(", ", word.Where(x => word.Where(y => y == x).Count() % 2 == 1).Distinct()));
        }
    }
}
