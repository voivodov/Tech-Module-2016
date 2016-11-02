using System; 
using System.Linq;

namespace _03.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string mystring = Console.ReadLine();
            foreach (int c in mystring)
            {
                string result = "\\u" + ((int)c).ToString("x4");
                Console.Write(result);
            }
            Console.WriteLine();
        }
    }
}
