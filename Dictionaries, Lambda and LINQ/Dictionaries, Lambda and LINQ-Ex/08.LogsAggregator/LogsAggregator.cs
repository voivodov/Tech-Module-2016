﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> data = new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] logsInfo = Console.ReadLine().Split();
                string ip = logsInfo[0];
                string user = logsInfo[1];
                int duration = int.Parse(logsInfo[2]);

                if (!data.ContainsKey(user))
                {
                    data.Add(user, new SortedDictionary<string, int>());
                }
                if (!data[user].ContainsKey(ip))
                {
                    data[user][ip] = 0;
                }

                data[user][ip] += duration;
            }

            foreach (var outerPair in data)
            {
                var sum = outerPair.Value.Values.Sum();

                Console.Write("{0}: {1} ", outerPair.Key, sum);
                Console.Write("[");
                Console.Write(string.Join(", ", outerPair.Value.Keys));
                Console.WriteLine("]");
            }
        }
    }
}
