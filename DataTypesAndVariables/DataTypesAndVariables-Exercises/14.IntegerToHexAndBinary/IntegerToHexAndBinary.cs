using System; 

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:X}", number);
            Console.WriteLine(Convert.ToString(number,2));
        }
    }
}
