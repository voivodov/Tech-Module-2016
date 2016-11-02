using System; 

namespace _06.TriplesOfLetters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + num; i++)
            {
                for (char g = 'a'; g < 'a' + num; g++)
                {
                    for (char d = 'a'; d < 'a' + num; d++)
                    {
                        Console.WriteLine($"{i}{g}{d}");
                    }
                }
            }
            
        }
    }
}
