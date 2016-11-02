using System; 
namespace _09.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int totalNumber = 0; int countNumber = 0; bool isTrue = false;
            for (int i = 1; i <= count; i++)
            {
                countNumber = i;
                while (i > 0)
                {
                    totalNumber += i % 10;
                    i = i / 10;
                }
                isTrue = (totalNumber == 5) || (totalNumber == 7) || (totalNumber == 11);
                Console.WriteLine($"{countNumber} -> {isTrue}");
                totalNumber = 0;
                i = countNumber;
            }

        }
    }
}
