using System; 

namespace _04.VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            int decimalValue = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(decimalValue);
        }
    }
}
