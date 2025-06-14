// The user enters the boundaries of a numerical range from the keyboard.
// It is necessary to display all Fibonacci numbers from this range.
// Fibonacci numbers are elements of a numerical sequence where the first two numbers are 0 and 1,
// and each subsequent number is the sum of the two preceding ones.
// For example, if the range is specified as 0–20, the result will be: 0, 1, 1, 2, 3, 5, 8, 13.
//

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            while (list.Count != 2)
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

            if (list[0] > list[1])
            {
                list.Reverse();
            }

            int display = 0;

            int feb = 1;

            while (display < list[1])
            {
                if (display >= list[0])
                {
                    Console.Write(display + " ");
                }

                int temp = display;
                display = feb;
                feb = temp + feb;
            }
        }
    }
}