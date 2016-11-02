using System; 

namespace _07.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before: \na = {num1}\nb = {num2} \nAfter:\na = {num2}\nb = {num1}");
        }
    }
}
