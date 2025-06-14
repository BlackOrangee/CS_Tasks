using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Vehicle
    {
        private string brand;

        private int year;

        public void setYear(int year)
        {
            this.year = year;
        }
        public int getYear()
        {
            return this.year;
        }
        public string getBrand()
        {
            return this.brand;
        }
        public void setBrand(string brand)
        {
            this.brand = brand;
        }

        public string Move()
        {
            return "Moving vehicle";
        }

        public string Stop()
        {
            return "Stopping vehicle";
        }
    }
}
