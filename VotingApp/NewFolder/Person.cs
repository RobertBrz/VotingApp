using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.NewFolder
{
    public class Person
    {
        public string Name { get; set; } = string.Empty;

        public Person( )
        {
            
        }

        public void SetName(string name )
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
