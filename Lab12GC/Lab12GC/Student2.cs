using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12GC
{
    class Student2 : Student
    {
            public Student2(string Name, string Address, string Program, int Year, double Fee) : base(Name, Address,Program, Year, Fee)
            {
            }

        new public string ToString()
        {
            return $"Student[{base.ToString()}]";
        }

        
    }
}
