using System; 

namespace _09.Reversed_chars
{
    class ReversedChars
    {
        static void Main(string[] args)
        {
            string charOne = Console.ReadLine();
            string charTwo = Console.ReadLine();
            string charTree = Console.ReadLine();
            Console.WriteLine($"{charTree}{charTwo}{charOne}");
        }
    }
}
