// The user enters a six-digit number from the keyboard.
// It is necessary to reverse the number and display the result.
// For example, if 341256 is entered, the result should be 652143.
//

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();


            while (list.Count != 1)
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

            String s_num = list[0].ToString();

            list.Clear();

            foreach (char str in s_num)
            {
                list.Add(Int32.Parse(str.ToString()));
            }

            list.Reverse();

            foreach (int num in list)
            {
                Console.Write(num);
            }

        }
    }

}
