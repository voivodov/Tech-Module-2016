using System;

namespace _01.Hello_Name
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Hallo(name);
        }

        private static void Hallo(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
