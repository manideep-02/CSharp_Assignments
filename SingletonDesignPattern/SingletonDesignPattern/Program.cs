using System;
using Singleton;
class Program
{
    static void Main(string[] args)
    {
        // Get the singleton instance of the VoteMachine by calling GetInstance Method
        VoteMachine voteMachine = VoteMachine.GetInstance();

        // Simulating casting votes for candidates
        voteMachine.VoteForCandidate(0);
        voteMachine.VoteForCandidate(1);
        voteMachine.VoteForCandidate(0);
        voteMachine.VoteForCandidate(2);
        voteMachine.VoteForCandidate(1);
        voteMachine.VoteForCandidate(0);
        voteMachine.VoteForCandidate(0);
        voteMachine.VoteForCandidate(0);
        voteMachine.VoteForCandidate(0);

        // Displaying the final vote results
        voteMachine.DisplayResults();
    }
}
