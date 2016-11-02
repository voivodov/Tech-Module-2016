using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RemovNegativAndReverse
{
    class RemovNegativAndReverse
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> endList = new List<int>() ;
            
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] > 0)
                {
                    endList.Add(myList[i]);
                }

            }
            endList.Reverse();
            if(endList.Count > 0)
                Console.WriteLine(string.Join(" ",endList));
            else
                Console.WriteLine("empty");
        }
    }
}
