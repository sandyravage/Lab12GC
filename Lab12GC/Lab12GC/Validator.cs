using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab12GC
{
    class Validator
    {
        public static string YesNoChecker(string input)
        {
            while(input != "y" && input != "n")
            {
                Console.Write("/nInvalid input. Please enter either \"y\" or \"n\": ");
                input = Console.ReadLine();
            }
            return input;
        }

        public static string StudentFieldEnterer(string message)
        {
            Console.Write("\n" + message);
            string input = Console.ReadLine();
            return input;
        }

        public static int ScoreChecker(string score)
        {
            int subscore;
            while(!int.TryParse(score, out subscore) || subscore < 1 || subscore > 100)
            {
                Console.Write("\nInvalid score. Please enter a value between 1 and 100: ");
                score = Console.ReadLine();
            }
            return subscore;
        }

        public static string NameChecker(string name)
        {
            while(!Regex.IsMatch(name,@"^[A-Z][a-z]+[ ][A-Z][a-z]+$"))
            {
                Console.Write("\nInvalid name. In name case, enter a first name followed by a last name with a space between: ");
                name = Console.ReadLine();
            }
            return name;
        }

        public static string SortChecker(string input)
        {
            while(input != "Last Name" && input != "Score")            
            {
                Console.Write("\nInvalid choice. Please enter either \"Last Name\" or \"Score\": ");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
