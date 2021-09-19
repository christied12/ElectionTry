using System;
using System.Collections.Generic;
// max function
using System.Linq;
namespace ElectionTry
{
    class Program
    {
        static void Main(string[] args)
        {

            // declare dictionary to refer to candidates names and affiliated parties (key, value, pair) n times

            Dictionary<string, string> candidates =
                new Dictionary<string, string>();

           int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string candidateName = Console.ReadLine();
                string candidateParty = Console.ReadLine();
                candidates.Add(candidateName, candidateParty);

            }

            //ballot Dictionary
            Dictionary<string, int> ballots = new Dictionary<string, int>();


            foreach (KeyValuePair<string, string> candidate in candidates)
            {

                ballots.Add(candidate.Key, 0);

            }


            //# of ballots
            int m = int.Parse(Console.ReadLine());

            //inputting ballots
            for (int i = 0; i < m; i++)
            {
                string nameOnBallot = Console.ReadLine();

                if (candidates.ContainsKey(nameOnBallot))
                    ballots[nameOnBallot] = ballots[nameOnBallot] + 1;
            }


            // find highest # of votes to declare winner
            int voteMax = ballots.Values.Max();

            // variables for finding the winner and displaying it
            int countWinners = 0;
            string winner = "";
            string winningParty = "";

            // 
            foreach (KeyValuePair<string, int> ballot in ballots)
            {

                if (ballot.Value == voteMax)
                {
                    countWinners += 1;
                    winner = ballot.Key;
                }

                else
                    continue;

            }


            //if countWinners more than 1 then tie
            if (countWinners == 1)
            {
                winningParty = candidates[winner];
                Console.WriteLine(winningParty);
            }

            else if (countWinners > 1)
                Console.WriteLine("tie");


            // notes and old ideas
            var dict = new Dictionary<string, int> { { "b", 3 }, { "a", 4 } };
            // greatest key
            var maxKey = dict.Keys.Max(); // "b"
            // greatest value
            var maxValue = dict.Values.Max(); // 4
            // key of the greatest value
            // 4 is the greatest value, and its key is "a", so "a" is the answer.
            var keyOfMaxValue = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key; // "a"

       










            // another loop to run m times to find max value in ballots dictionary
            // for each 2 loops, 2 dictionaries, and if statements
            // check if max value appears more than once = "tie"
            // if no tie, reference candidate dictionary, display value associated with key
            // test if blank line = no, so substitue independent
        }
    }
}
