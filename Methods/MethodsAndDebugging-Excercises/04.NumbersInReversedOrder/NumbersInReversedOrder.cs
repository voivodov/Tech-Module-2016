using System; 

namespace _04.NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            string number =  Console.ReadLine();

            Console.WriteLine(ReverNumber(number)); 
        }

        static string ReverNumber(string number)
        {
            string result = "";
            for (int i = number.Length - 1 ; i >= 0 ;i--)
            {
                result += number[i];
                
            }
            return result;
        }
    }
}
