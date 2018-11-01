using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12GC
{
    class Program
    {
        public static List<ArchivedStudent> students = new List<ArchivedStudent>();

        static void Main()
        {
            Console.Write("Welcome to the Archived Student list thing!" +
                "\nPlease begin by adding some students --");
            System.Threading.Thread.Sleep(4000);

            while (true)
            {
                Console.Clear();
                ListMethods.AddStudent(ref students);
                Console.Write("\nStudent added!\n" +
                    "\nWould you like to add another? (y/n): ");
                if (Validator.YesNoChecker(Console.ReadLine()) == "y")
                {
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Clear();
                Console.Write("Choose a way to sort the list before displaying it-- ");
                ListMethods.ListSorter(ref students);
                Console.Write("\nDisplaying students . . . \n\n");
                foreach(var student in students)
                {
                    Console.Write(student.ToString() +"\n\n");
                }
                Console.Write("\nSort again? (y/n): ");
                if (Validator.YesNoChecker(Console.ReadLine()) == "y")
                {
                    continue;
                }
                break;
            }

            Console.Write("\n\n---Console will now terminate---");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
