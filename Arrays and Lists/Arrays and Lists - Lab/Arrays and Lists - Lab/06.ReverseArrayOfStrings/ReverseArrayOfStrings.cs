using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(string.Join(" ", inputString.Reverse()));
            
        }
    }
}
