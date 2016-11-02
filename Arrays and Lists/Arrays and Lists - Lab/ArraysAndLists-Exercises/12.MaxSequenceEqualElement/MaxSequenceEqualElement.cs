using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MaxSequenceEqualElement
{
    class MaxSequenceEqualElement
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();

            int counter = 1;
            int tempCounter = 1;
            double resultNum = list[0];

            for (int i = 0; i < list.Count; i++)
            {
                if (i + 1 >= list.Count)
                {
                    break;
                }
                if ((list[i] == list[i + 1]) && ((i + 1) < list.Count))
                {
                    tempCounter++;
                    if (tempCounter > counter)
                    {
                        resultNum = list[i];
                        counter = tempCounter;
                    }
                }
                else
                {
                    tempCounter = 1;
                }

            }
            for (int i = 0; i < counter; i++)
            {
                Console.Write(resultNum + " ");
            }
        }
    }
}
