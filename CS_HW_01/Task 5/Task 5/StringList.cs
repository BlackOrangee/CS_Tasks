using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    internal class StringList
    {
        private List<String> list = new List<String>();

        public StringList() { }

        public StringList(String str) 
        {
            list.Add(str);
        }

        public void Add(String str)
        {
            list.Add(str);
        }

        public void CheckStrings()
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].ToLower();
            }
        }

        public int CalculateWords() 
        { 
            return list.Count; 
        }

        public string GetString(int index)
        {
            return list[index].ToString();
        }

        public int GetCount() 
        { 
            return list.Count;
        }
    }
}
