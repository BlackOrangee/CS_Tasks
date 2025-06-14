using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyNamespace
{
    internal class Task2
    {
        public static void Execute()
        {
            Console.WriteLine("Task 2");

            string pattern = "(\\+380\\d{9})";
            string phone;

            Console.WriteLine($"Enter phone number\n");

            phone = Console.ReadLine();

            Match match = Regex.Match(phone, pattern);

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
