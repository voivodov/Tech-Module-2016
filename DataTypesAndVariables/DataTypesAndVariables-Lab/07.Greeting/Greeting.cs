using System; 

namespace _07.Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string wholeName = firstName + " " + secondName;
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, {0}. You are {1} years old.", wholeName, age);
        }
    }
}
