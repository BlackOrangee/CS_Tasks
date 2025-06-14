// The user enters five numbers from the keyboard.
// It is necessary to find the sum, maximum, and minimum of the five numbers,
// as well as the product of the numbers.
// Display the results on the screen.
//

namespace MyNamespace
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

            int sum = 0;

            foreach (int num in list)
            {
                sum += num;
            }

            Console.WriteLine("sum: " + sum);


            int pow = 1;

            foreach (int num in list)
            {
                pow *= num;
            }
            Console.WriteLine("pow: " + pow);

            Console.WriteLine("max: " + list.Max());
            Console.WriteLine("min: " + list.Min());
            Console.ReadLine();
        }
    }
}