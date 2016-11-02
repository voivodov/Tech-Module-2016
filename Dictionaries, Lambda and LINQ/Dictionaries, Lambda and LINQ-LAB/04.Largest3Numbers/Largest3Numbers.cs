using System;
using System.Collections.Generic;
using System.Linq; 

namespace _04.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            nums.Sort();
            nums.Reverse();
            
            Console.WriteLine(string.Join(" ",nums.Take(3)));
        }
    }
}
