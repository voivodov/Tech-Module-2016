using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var counts = new SortedDictionary<double, int>();

            foreach (var num in nums )
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }
            foreach (var item in counts.Keys)
            {
                if(counts[item] > 0)
                    Console.WriteLine("{0} -> {1}",item, counts[item]);
            }
        }
    }
}
