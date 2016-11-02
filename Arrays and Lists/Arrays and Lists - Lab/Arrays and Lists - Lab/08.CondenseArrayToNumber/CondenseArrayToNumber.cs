﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace _08.CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            List<long> sequence = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            while (sequence.Count > 1)
            {
                for (int i = 0; i < sequence.Count - 1; i++)
                {
                    sequence[i] += sequence[i + 1];
                }

                sequence.RemoveAt(sequence.Count - 1);
            }

            Console.WriteLine(sequence[0]);
        }
    }
}
