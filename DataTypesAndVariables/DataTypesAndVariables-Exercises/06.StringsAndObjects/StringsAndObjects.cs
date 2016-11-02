using System; 

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string firstPart = Console.ReadLine();
            string secondPart = Console.ReadLine();
            object wholePartObject = firstPart + " " + secondPart;
            Console.WriteLine(wholePartObject);
        }
    }
}
