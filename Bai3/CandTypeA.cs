using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{

    class CandTypeA : Candidate
    {
        public const string Math = "Math";
        public const string Physics = "Physics";
        public const string Chemistry = "Chemistry";
        public CandTypeA(int id, string name, string address, Priority priority) : base(id, name, address, priority)
        {

        }

        public override string ToString()
        {
            return base.ToString()+$" Group A, Test subjects are {Math}, {Physics} and {Chemistry}";
        }
}
