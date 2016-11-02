using System; 

namespace _08.MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            int sumOdd = GetSumOdd(input);
            int sumEven = GetSumEven(input);
            Console.WriteLine(Math.Abs((decimal)(sumEven *(int) sumOdd)));

        }

        private static int GetSumEven(int input)
        {
            int sum = 0;
            while (input > 0)
            {
                int lastDigit = input % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                input /= 10;
            }
            return sum;
        }

        private static int GetSumOdd(int input)
        {
            int sum = 0;
            while (input>0)
            {
                int lastDigit = input % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                input /= 10;
            }
            return sum;
        }
    }
}
