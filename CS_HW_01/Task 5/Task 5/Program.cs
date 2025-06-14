// Create a program that uses List<T> to store a list of words.
// The program should perform the following actions:
// 1. Populate the list with words entered by the user.
// 2. Validate the entered words using standard string methods.
//     If a word fails validation, remove it from the list.
// 3. Display the number of words in the list and the list itself on the screen.
//

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args) 
        {
            StringList list = new StringList();

            list.Add("Apple");
            list.Add("Cup");
            list.Add("Battery");

            list.CheckStrings();

            for (int i = 0; i < list.GetCount(); i++)
            {
                Console.WriteLine(list.GetString(i));
            }
        }
    }
}