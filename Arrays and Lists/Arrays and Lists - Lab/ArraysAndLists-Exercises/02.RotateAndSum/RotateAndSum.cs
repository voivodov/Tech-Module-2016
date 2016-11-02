using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = int.Parse(Console.ReadLine());

            int[] sumOfRotations = new int[nums.Length];
            for (int curentRotation = 0; curentRotation < count; curentRotation++)
            {
                int lastElement = nums[nums.Length - 1];
                for (int curentElement = nums.Length-1;curentElement>0;curentElement--)
                {
                    nums[curentElement] = nums[curentElement - 1];
                }
                nums[0] = lastElement;
                for (int currentElemnt = 0; currentElemnt < nums.Length; currentElemnt++)
                {
                    sumOfRotations[currentElemnt] += nums[currentElemnt];
                }
            }
            Console.WriteLine(string.Join(" ", sumOfRotations));
        }
    }
}
