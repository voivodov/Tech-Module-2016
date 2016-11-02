using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dictionary<string, string> emails = new Dictionary<string, string>();
            while (name != "stop")
            {
                string email = Console.ReadLine();
                string subEmail = email.Substring(email.Length - 2);
                if (subEmail != "us" && subEmail != "uk")
                {
                    emails.Add(name, email);
                }
                else
                {
                    name = Console.ReadLine();
                }
                name = Console.ReadLine();
            }
            foreach (KeyValuePair<string, string> kvp in emails)
            {

                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
