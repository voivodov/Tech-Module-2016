using System; 

namespace _02.ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
           
            int[] arr = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int k = arr.Length-1; k >= 0 ; k--)
            {
                Console.Write(arr[k] + " ");
            }
        }
    }
}
