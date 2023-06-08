using System;
using System.Collections.Generic;

namespace Bai3
{
    class CandTypeC : Candidate
    {
        public const string Literature = "Literature";
        public const string History = "History";
        public const string Geography = "Geography";
        public CandTypeC(int id, string name, string address, Priority priority) : base(id, name, address, priority)
        {
        }
        public override string ToString()
        {
            return base.ToString() + $" Group A, Test subjects are {Literature}, {History} and {Geography}";
        }
    }
}
