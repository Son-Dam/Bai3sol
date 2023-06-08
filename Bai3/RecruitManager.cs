using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class RecuritManager
    {
        private List<Candidate> candidates;
        public RecuritManager() {
            candidates = new List<Candidate>();

        }

        public void AddCandidate(Candidate candidate) {
            candidates.Add(candidate);
        }
        public void Print(List<Candidate>candidates){
            foreach(var c in candidates)
            {
                Console.WriteLine(c.ToString());
            }
        }
        public Candidate FindCandidate(int id)
        {
            foreach (var candidate in candidates)
            {
                if (candidate.Id == id) return candidate;
            }
            return null;
        }
    }
}
