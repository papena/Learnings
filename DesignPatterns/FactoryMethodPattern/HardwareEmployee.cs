using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class HardwareEmployee : IEmployee
    {
        public int GetSalary(int val)
        {
            return val;
        }
    }
}
