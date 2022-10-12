using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.NewFolder
{
    [DataContract]
    public class Candidate : Person
    {
        [DataMember] public int Votes { get; private set; } = 0;

        public Candidate() : base()
        {

        }

        public void IncrementVotes()
        {
            Votes++;
        }
    }
}
