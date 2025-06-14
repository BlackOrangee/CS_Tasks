using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyNamespace
{
    internal class Task3
    {
        public static void Execute()
        {
            Console.WriteLine("Task 3");

            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*()_+])[A-Za-z\\d!@#$%^&*()_+]{8,}";
            string pass;

            Console.WriteLine($"Enter the password\n");

            pass = Console.ReadLine();

            Match match = Regex.Match(pass, pattern);

            if (match.Success)
            {
                Console.WriteLine($"Correct");
            }
            else
            {
                Console.WriteLine($"Wrong");
            }
        }
    }
}
