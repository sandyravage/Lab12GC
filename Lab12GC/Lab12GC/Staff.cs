using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12GC
{
    class Staff : Person
    {
        protected string school;
        protected double pay;

        public Staff(string Name, string Address, string School, double Pay):base(Name,Address)
        {
            school = School;
            pay = Pay;
        }

        public override string ToString()
        {
            return $"Staff[{base.ToString()},school={school},pay={pay}]";
        }
    }
}
