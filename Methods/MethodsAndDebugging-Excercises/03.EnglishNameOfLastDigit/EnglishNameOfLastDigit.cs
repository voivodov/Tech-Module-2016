using System; 

namespace _03.EnglishNameOfLastDigit
{
    class EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            long inputNumber = long.Parse(Console.ReadLine());
            inputNumber = Math.Abs(inputNumber);
            
            Console.WriteLine(EnglishLastDigit(inputNumber));
        }

        public static string EnglishLastDigit(long inputNumber)
        {
            if (inputNumber % 10 == 1)
            {
                return "one";
            }
            else if (inputNumber % 10 == 2)
            {
                return "two";
            }
            else if (inputNumber % 10 == 3)
            {
                return "three";
            }
            else if (inputNumber % 10 == 4)
            {
                return "four";
            }
            else if (inputNumber % 10 == 5)
            {
                return "five";
            }
            else if (inputNumber % 10 == 6)
            {
                return "six";
            }
            else if (inputNumber % 10 == 7)
            {
                return "seven";
            }
            else if (inputNumber % 10 == 8)
            {
                return "eight";
            }
            else if (inputNumber % 10 == 9)
            {
                return "nine";
            }
            else 
                return "zero";
        }
    }
}
