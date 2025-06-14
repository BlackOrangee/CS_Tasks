using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СS_HW_02_Svyrydov
{
    internal class MyArray : IMath, IOutput, ISort
    {
        private List<int> list;
        private bool isSorted;
        private bool asc;
        private bool desc;

        public MyArray()
        {
            list = new List<int>();
            isSorted = false;
        }

        public void Add(int value)
        { 
            list.Add(value);
            isSorted = false;
            asc = false;
            desc = false;
        }

        private int BinarySearch(int valueToSearch)
        {
            if (!isSorted || valueToSearch < 0)
                return -1;


            int min = 0;
            int max = list.Count - 1;

            while (min <= max)
            {
                int midl = min + (max - min) / 2;


                if (list[midl] == valueToSearch)
                    return midl;

                if (list[midl] > valueToSearch)
                    max = midl - 1;
                else
                    min = midl + 1;
            }

            return -2;
        }

        public float Avg()
        {
            if (isSorted)
                return list[list.Count - 1] - list[0];

            int avg = 0;

            foreach (int i in list)
                avg += i;

            return avg / list.Count;
        }

        public int Max()
        {
            if (isSorted && asc)
                return list[list.Count - 1];

            if (isSorted && desc)
                return list[0];

            int max = Int32.MinValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                    max = list[i];
            }

            return max;
        }

        public int Min()
        {
            if (isSorted && asc)
                return list[0];

            if (isSorted && desc)
                return list[list.Count - 1];

            int min = Int32.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }   

            return min;
        }

        public bool Search(int valueToSearch)
        {
            if (BinarySearch(valueToSearch) == -1)
            {
                Console.WriteLine("Array is unsorted");
                return false;
            }

            if (BinarySearch(valueToSearch) == -2)
                return false;

            return true;
        }

        public void Show()
        {
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
        }

        public void Show(string message)
        {
            Console.WriteLine($"{message}");
        }

        public void SortAsc()
        {
            bool sorted = false;

            while (!sorted)
            {
                if (list.Count <= 1)
                    break;

                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        int temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        sorted = false;
                        break;
                    }
                    sorted = true;
                }
            }
            isSorted = true;
            asc = true;
            desc = false;
        }

        public void SortDesc()
        {
            bool sorted = false;

            while (!sorted)
            {
                if (list.Count <= 1)
                    break;

                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] < list[i + 1])
                    {
                        int temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        sorted = false;
                        break;
                    }
                    sorted = true;
                }
            }
            isSorted = true;
            desc = true;
            asc = false;
        }
    }
}
