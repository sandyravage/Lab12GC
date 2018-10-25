using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12GC
{
    class Program
    {
        static void Main()
        {
            Person person = new Person("Geoff", "1234 Bunyip Way, Australia");
            Student student = new Student("Yams", "555 Halacious Windstorm Boulevard, England","Underwater Basketweaving",2018,35000);
            Staff staff = new Staff("Undertaker Harold", "77 Big Bumpin' Avenue", "Teak Teak Elementary", 78000);

            Console.WriteLine($"{person.ToString()}\n\n{student.ToString()}\n\n{staff.ToString()}");

            Console.ReadKey();
        }
    }
}
