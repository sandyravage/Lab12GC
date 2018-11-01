using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12GC
{
    class ListMethods
    {
        public static void AddStudent(ref List<ArchivedStudent> list)
        {
            list.Add(new ArchivedStudent(Validator.NameChecker(Validator.StudentFieldEnterer("Enter a name: ")), Validator.ScoreChecker(Validator.StudentFieldEnterer("Enter a score: "))));
        }

        public static void ListSorter(ref List<ArchivedStudent> list)
        {
            Console.Write("\nSelect either \"Score\" or \"Last Name\": ");
            string choice = Validator.SortChecker(Console.ReadLine());
            if(choice == "Score")
            {
                list.Sort(delegate (ArchivedStudent @this, ArchivedStudent that)
                {
                    if (@this.finalScore < that.finalScore)
                    {
                        return 1;
                    }
                    else if (@this.finalScore > that.finalScore)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                });
            }
            else
            {
                list.Sort();
            }
        }
    }
}