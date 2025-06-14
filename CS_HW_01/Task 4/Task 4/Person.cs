using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    internal class Person
    {
        private string name;
        private int age;

        public Person() { }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return name + " : " + age.ToString();
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public string getName()
        {
            return name;
        }

    }
}
