using System; 

namespace _01.CountWorkDays
{
    class CountWorkDays
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var strArr = new char[str.Length];
            for (int i = 0, k = str.Length-1 ; i < str.Length; i++,k--)
            {
                strArr[i] = str[k];
            } 
            Console.WriteLine(string.Join("",strArr));
        }
    }
}
