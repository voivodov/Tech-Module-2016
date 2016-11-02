using System; 

namespace _04.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           Line(number); 
        }

         
        static void Line(int n)
        {
            Console.WriteLine(new string('-', n*2));
            for (int k = 0; k < n-2; k++)
            {
                Console.Write("-");
                for (int i = 0; i < n - 1; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
