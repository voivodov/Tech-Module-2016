using System; 

namespace _02.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int index = text.IndexOf(word);
            int count = 0;
            while (index != -1)
            {
                index = text.IndexOf(word, index + 1);
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
