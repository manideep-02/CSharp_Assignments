using System;

namespace Singleton
{
    // Singleton class representing a vote machine
    public sealed class VoteMachine
    // We used sealed class to restrict the inheritance
    {
        //This static variable is going to store the VoteMachine Instance
        private static VoteMachine instance = null;

        // Array to store candidate names
        private string[] candidates;

        // Array to store corresponding vote counts
        private int[] voteCounts;

        private int candidateCount = 3; // Number of candidates

        //This static variable value will be increment by 1 each time the object of the class is created
        private static int count = 0;

        /*  Constructor is Private means, from outside the class we cannot create an instance of this class
           But within the class, we can create an instance */
        private VoteMachine()
        {
            //Each Time the Constructor is called When Object is created and increment the Counter value by 1
            count++;
            Console.WriteLine("Number of Objects Created : "+count);

            // Initializing arrays to store candidate names and vote counts
            candidates = new string[candidateCount];
            voteCounts = new int[candidateCount];

            // Initializing candidate names and vote counts
            for (int i = 0; i < candidateCount; i++)
            {
                candidates[i] = $"Candidate {i + 1}"; // Example: Candidate 1, Candidate 2, ...
                voteCounts[i] = 0; // Initialize vote count to zero
            }
        }

        //The following Static Method is going to create the instance and return the VoteMachine Instance
        public static VoteMachine GetInstance()
        {
            /* If the variable instance is null, then create the VoteMachine instance
              else return the already created VoteMachine instance
              This version is not thread-safe */
            if (instance == null)
            {
                instance = new VoteMachine(); // Create a new instance if one doesn't exist
            }
            //Return the Instance
            return instance;
        }

        // Method to record a vote for a candidate
        public void VoteForCandidate(int candidateIndex)
        {
            // Check if the provided candidate index is valid
            if (candidateIndex >= 0 && candidateIndex < candidateCount)
            {
                voteCounts[candidateIndex]++; // Increment the vote count for the selected candidate
            }
            else
            {
                Console.WriteLine("Invalid candidate selection.");
            }
        }

        // Method to display the final vote results
        public void DisplayResults()
        {
            Console.WriteLine("Vote Results:");
            for (int i = 0; i < candidateCount; i++)
            {
                // Displaying candidate name and their corresponding vote count
                Console.WriteLine($"{candidates[i]}: {voteCounts[i]} votes");
            }
        }
    }
}