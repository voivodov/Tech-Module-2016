using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();
            items.Reverse();
            var results = new List<string>();
            
            foreach (var item in items)
            {
                List<string> nums = item.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        results.Add(num);
                    }
                }
               
            }
            Console.WriteLine(string.Join(" ", results));
        }
    }
}
