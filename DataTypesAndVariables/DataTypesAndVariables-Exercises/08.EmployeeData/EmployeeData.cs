using System; 

namespace _08.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            long personalID = long.Parse(Console.ReadLine());
            uint employee = uint.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {name}\nLast name: {lastName}\nAge: {age}\nGender: {sex}\nPersonal ID: {personalID}\nUnique Employee number: {employee}");
        }
    }
}
