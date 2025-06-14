// 
//

namespace СS_HW_02_Svyrydov
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray();

            myArray.Add(7);
            myArray.Add(3);
            myArray.Add(9);
            myArray.Add(2);
            myArray.Add(4);
            myArray.Add(10);
            myArray.Add(6);
            myArray.Add(8);
            myArray.Add(1);
            myArray.Add(5);

            myArray.Show("Unsorted array");
            myArray.Show();

            myArray.SortDesc();
            myArray.Show("\n\nSorted desc array");
            myArray.Show();

            myArray.SortAsc();
            myArray.Show("\n\nSorted asc array");
            myArray.Show();

            myArray.Show($"\n\nMin: {myArray.Min()}");
            myArray.Show($"\nMax: {myArray.Max()}");

            if (myArray.Search(5))
            {
                Console.WriteLine("\n5 is in array");
            }
            else
            {
                Console.WriteLine("\n5 is`t in array");
            }
            
        }
    }

}