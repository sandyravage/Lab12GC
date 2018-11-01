using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12GC
{
    class Person
    {
        protected internal string name;
        protected string address;

        public Person()
        {

        }

        public Person(string Name, string Address)
        {
            name = Name;
            address = Address;
        }

        public override string ToString()
        {
            return $"Person[name={name},address={address}]";
        }
    }
}
