using System; 

namespace _05.BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            bool boolVarble = Convert.ToBoolean(Console.ReadLine());
            if (boolVarble)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
