using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12GC
{
    class ArchivedStudent : Student, IComparable<ArchivedStudent>
    {
        internal int finalScore { get; }

        public ArchivedStudent(string Name, int FinalScore)
        {
            string[] arr = Name.Split(' ');
            string subName = arr[1] + ", " + arr[0];
            name = subName;
            finalScore = FinalScore;
        }
        public ArchivedStudent(string Name, string Address, string Program, int Year, double Fee, int FinalScore) : base(Name, Address, Program, Year, Fee)
        {
            finalScore = FinalScore;
        }

        public int CompareTo(ArchivedStudent that)
        {
            return string.Compare(this.name, that.name);
        }

        public override string ToString()
        {
            return $"Student: {name} Final Score: {finalScore}";
        }
    }
}
