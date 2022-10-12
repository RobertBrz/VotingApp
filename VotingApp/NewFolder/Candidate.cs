using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.NewFolder
{
    public class Candidate : Person
    {
        public int Votes { get; set; } = 0;

        public Candidate() : base( )
        {

        }

        public void IncrementVotes()
        {
            Votes++;
        }
    }
}
