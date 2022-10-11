using System.Windows.Navigation;

namespace VotingApp
{
    internal class GetStringPageFunction
    {
        public GetStringPageFunction()
        {
        }

        public ReturnEventHandler<string> Return { get; internal set; }
    }
}