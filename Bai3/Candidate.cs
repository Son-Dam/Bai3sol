using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    enum Priority {
        Normal,
        ChildOfOfficer,
        EthnicPeople,
    }

    class Candidate
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Priority Priority{ get; set; }

        public Candidate(int id, string name, string address, Priority priority)
        {
            Id = id;    
            Name = name;
            Address = address;
            Priority = priority;
        }
        public override string ToString()
        {
            return $"Candidate {Name}, Id: {id}, Address: {Address}, priority type: {Priority}";
        }
    }
}
