using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ', '!', '?', '.',',' },StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            foreach (string word in words.Distinct().OrderBy(w=>w))
            {
                if (IsPaindome(word))
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", palindromes));

        }
        static bool IsPaindome(string word)
        {
            bool result = word == string.Join("", word.Reverse());
           
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }


    }
    
}
