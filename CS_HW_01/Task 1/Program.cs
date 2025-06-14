using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Create a program that performs the following actions:
//  Create an array of integers with a size of 5 elements.
//  Fill the array with values entered by the user.
//  Display the contents of the array on the screen.
//  Find and display the maximum and minimum elements of the array.
//

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();


            while (list.Count != 5)
            {
                try
                {
                    string str = Console.ReadLine();

                    if (str != null)
                    {
                        int num = Int32.Parse(str);
                        list.Add(num);
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (int num in list)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("max: " + list.Max());
            Console.WriteLine("min: " + list.Min());

            Console.ReadLine();
        }
    }
}
