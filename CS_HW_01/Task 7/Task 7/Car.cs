using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Car : Vehicle
    {
        public string Move()
        {
            return "Moving car";
        }
        
        public string Stop()
        {
            return "Stopping car";
        }
    }
}
