﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

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
                commandLine = Console.ReadLine();
            }
        }
    }
}
