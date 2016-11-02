using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] bombInfo = Console.ReadLine().Split();
            int target = int.Parse(bombInfo[0]);
            int radius = int.Parse(bombInfo[1]);

            while (numbers.Contains(target))
            {
                int index = -1;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (target == numbers[i])
                    {
                        index = i;
                        break;
                    }
                }
                int bombBlast = 2 * radius + 1;

                int startIndex = Math.Max(0, index - radius);
                int count = Math.Min(bombBlast, numbers.Count - startIndex);
                numbers.RemoveRange(startIndex, count);
            }

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
