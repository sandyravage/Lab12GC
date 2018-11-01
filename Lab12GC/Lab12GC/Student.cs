using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12GC
{
    class Student : Person
    {
        protected string program;
        protected int year;
        protected double fee;

        public Student()
        {

        }
        public Student(string Name, string Address, string Program, int Year, double Fee):base(Name, Address)
        {
            program = Program;
            year = Year;
            fee = Fee;
        }

        public override string ToString()
        {
            return $"Student[{base.ToString()},program={program},year={year},fee={fee}]";
        }
    }
}
