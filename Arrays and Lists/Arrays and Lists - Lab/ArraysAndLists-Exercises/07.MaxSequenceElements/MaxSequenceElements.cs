using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceElements
{
    class MaxSequenceElements
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (char letter in input)
            {
                if (char.IsLetter(letter))
                {
                    char smallLetter = letter.ToString().ToLower()[0];
                    Console.WriteLine($"{letter} -> {(smallLetter - 97)}");
                }
            }
        }
    }
}
