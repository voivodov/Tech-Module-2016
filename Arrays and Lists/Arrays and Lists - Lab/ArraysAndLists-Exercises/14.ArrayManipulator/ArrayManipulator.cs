﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                string command = commands[0];
                if (command == "print") break;
                if (command == "add")
                {
                    add(nums, commands);
                }
                else if (command == "addMany")
                {
                    addMany(nums, commands);
                }
                else if (command == "contains")
                {
                    contains(nums, commands);
                }
                else if (command == "remove")
                {
                    remove(nums, commands);
                }
                else if (command == "shift")
                {
                    shift(nums, commands);
                }
                else if (command == "sumPairs")
                {
                    nums = sumPairs(nums);
                }
            }
            Console.WriteLine("[" + string.Join(", ", nums) + "]");
        }

        private static List<int> sumPairs(List<int> nums)
        {
            List<int> summed = new List<int>();
            while (nums.Count >= 2)
            {
                summed.Add(nums[0] + nums[1]);
                nums.RemoveAt(0);
                nums.RemoveAt(0);
            }
            if (nums.Count == 1) summed.Add(nums[0]);

            nums = summed;
            return nums;
        }

        private static void shift(List<int> nums, string[] commands)
        {
            int numberOfPositions = int.Parse(commands[1]);
            while (numberOfPositions > 0)
            {
                int first = nums[0];
                nums.RemoveAt(0);
                nums.Add(first);
                numberOfPositions--;
            }
        }

        private static void remove(List<int> nums, string[] commands)
        {
            int index = int.Parse(commands[1]);
            nums.RemoveAt(index);
        }

        private static void contains(List<int> nums, string[] commands)
        {
            int element = int.Parse(commands[1]);
            if (nums.Contains(element))
            {
                Console.WriteLine(nums.IndexOf(element));
            }
            else Console.WriteLine("-1");
        }

        private static void addMany(List<int> nums, string[] commands)
        {
            int index = int.Parse(commands[1]);
            for (int i = commands.Length - 1; i >= 2; i--)
            {
                int element = int.Parse(commands[i]);
                nums.Insert(index, element);
            }
        }

        private static void add(List<int> nums, string[] commands)
        {
            int index = int.Parse(commands[1]);
            int element = int.Parse(commands[2]);
            nums.Insert(index, element);
        }
    }
}

