using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class SoftwareEmployee : IEmployee
    {
        public int GetSalary(int val)
        {
            return val;
        }
    }
}
