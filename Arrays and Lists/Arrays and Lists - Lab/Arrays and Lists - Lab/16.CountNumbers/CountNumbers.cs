﻿using System;
using System.Collections.Generic;
using System.Linq; 

namespace _16.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] counts = new int[1001];
            foreach (var num in nums)
            {
                counts[num]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if(counts[i] >  0)
                Console.WriteLine($"{i} -> {counts[i]}");
            }
        }
    }
}
