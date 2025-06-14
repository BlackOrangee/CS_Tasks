using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyNamespace
{
    internal class Task1
    {
        public static void Execute()
        {
            Console.WriteLine("Task 1");

            string pattern = "([A-Za-z]+@itstep.ua)";
            string email = " aa@itstep.ua";

            Console.WriteLine($"Enter @itstep.ua email\n");

            email = Console.ReadLine();

            Match match = Regex.Match(email, pattern);

            if (match.Success)
            {
                Console.WriteLine($"correct");
            }
            else
            {
                Console.WriteLine($"Wrong");
            }
        }
    }
}
