using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Xps.Serialization;

namespace VotingApp.NewFolder
{
    public class Voter : Person 
    {
        public bool HasVoted { get;private  set; } = false;

        public Voter() : base()
        {

        }

        public void SetVoteState(bool state = true)
        {
            HasVoted = state;
        }
    }
}
