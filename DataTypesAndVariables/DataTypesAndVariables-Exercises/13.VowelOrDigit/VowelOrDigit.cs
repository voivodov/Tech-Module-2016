using System; 

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char chars = char.Parse(Console.ReadLine());
            if (chars == 'a' || chars == 'A' || chars == 'e' || chars == 'E' || chars == 'i' || chars == 'I' || chars == 'o' || chars == 'O' ||
                chars == 'u' || chars == 'U' || chars == 'y' || chars == 'Y')
            {
                Console.WriteLine("vowel");
            }
            else if (chars >= (char)48 && chars <= (char)57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
                
        }
    }
}
