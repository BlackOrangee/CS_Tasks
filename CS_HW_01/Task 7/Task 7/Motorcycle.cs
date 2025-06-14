using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Motorcycle : Vehicle
    {
        public string Move()
        {
            return "Moving motorcycle";
        }

        public string Stop()
        {
            return "Stopping motorcycle";
        }
    }
}
