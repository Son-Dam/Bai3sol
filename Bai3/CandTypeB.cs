using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{

    class CandTypeB : Candidate
    {
        public const string Math = "Math";
        public const string Biology = "Biology";
        public const string Chemistry = "Chemistry";
        public CandTypeB(int id, string name, string address, Priority priority) : base(id, name, address, priority)
        {
        }
        public override string ToString()
        {
            return base.ToString() + $" Group A, Test subjects are {Math}, {Biology} and {Chemistry}";
        }
    }
}
