using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            List <char> chars = Console.ReadLine().Split().Select(char.Parse).ToList();
            List < char > secondsChar = Console.ReadLine().Split().Select(char.Parse).ToList();

            int len = Math.Min(chars.Count, secondsChar.Count);
            bool areDifferent = false;
            for (int i = 0; i < len; i++)
            {
                if (chars[i] > secondsChar[i])
                {
                    Console.WriteLine(string.Join("",secondsChar));
                    Console.WriteLine(string.Join("", chars));
                    areDifferent = true;
                    break;
                }
                else if (chars[i] < secondsChar[i])
                {
                    Console.WriteLine(string.Join("", chars));
                    Console.WriteLine(string.Join("", secondsChar));
                    areDifferent = true;
                    break;
                }
                
            }
            if (!areDifferent)
            {
                if (chars.Count <= secondsChar.Count)
                {
                    Console.WriteLine(string.Join("", chars));
                    Console.WriteLine(string.Join("", secondsChar));
                }
                else
                {
                    Console.WriteLine(string.Join("", secondsChar));
                    Console.WriteLine(string.Join("", chars));
                }
                
                    
            }

        }
    }
}
