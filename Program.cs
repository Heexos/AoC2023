using System;
using AoC2023.Challenges;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a new instance of the ChallengeManager class
        ChallengeManager challengeManager = new ChallengeManager();

        // Get all the challenges
        var challenges = challengeManager.GetChallenges();

        while (true)
        {
            Console.WriteLine("### Advent Of Code 2023 ###\n");
            Console.WriteLine("List of challenges :");

            foreach (var challenge in challenges)
            {
                Console.WriteLine($" + Day {challenge.Id}:  {challenge.Name}");
            }

            Console.WriteLine("\nSelect a challenge or exit: ");
            // Read the user input
            string input = Console.ReadLine();

            if (input == "exit")
            {
                Console.WriteLine("Bye!");
                return;
            }

            // Check if the input is a valid id
            var selectedChallenge = challenges.Find(c => c.Id.ToString() == input);

            if (selectedChallenge == null)
            {
                Console.WriteLine("Invalid challenge id");
                    
            } else
            {
                return;
            }
            

            // Clear the console
            Console.Clear();
        }
    }
}