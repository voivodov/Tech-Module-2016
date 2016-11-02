using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string commandLine = Console.ReadLine();

            while (!commandLine.Equals("END"))
            {
                string[] commandArgs = commandLine.Split();

                if (commandLine[0] == 'A')
                {
                    string contact = commandArgs[1];
                    string number = commandArgs[2];

                    phonebook[contact] = number;
                }
                else if (commandLine[0] == 'S')
                {
                    string contact = commandArgs[1];

                    if (phonebook.ContainsKey(contact))
                        Console.WriteLine("{0} -> {1}", contact, phonebook[contact]);

                    else
                        Console.WriteLine("Contact {0} does not exist.", contact);
                }
                else if (commandLine == "ListAll")
                {
                     
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
                    }
                }
                commandLine = Console.ReadLine();
            }
        }
    }
}
