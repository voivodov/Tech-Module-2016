using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            string[] shortWords =
                Console.ReadLine()
                    .ToLower()
                    .Split(new[] { ',', '.', ':', ';', '!', '?', ' ', '\'', '(', ')', '[', ']', '\"' }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(w => w.Length < 5)
                    .OrderBy(word => word)
                    .Distinct()
                    .ToArray();

            Console.WriteLine(string.Join(", ", shortWords));
        }
    }
}
