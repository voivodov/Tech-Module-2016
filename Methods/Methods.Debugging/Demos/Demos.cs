using System; 

namespace Demos
{
    class Demos
    {
        static void PrintNumber(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintStudend(string name, int age, double grade)
        {
            Console.WriteLine($"Student: {name}; \nAge: {age}\nGrade: {grade}; ");
        }
        static void PrintSing(int number)
        {
            if (number>0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if(number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
                Console.WriteLine($"The number {number} is zero.");
        }
        static void PrintLine(int start, int end)
        {
            for(int i = start; i<=end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void PrintTriangle(int n)
        {
            int line;
            for (line = 1; line < n; line++)
            {
                PrintLine(1, line);
            }

            for (; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n); 
        }
    }
}
