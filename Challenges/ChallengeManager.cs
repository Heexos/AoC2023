using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2023.Challenges
{
    public class ChallengeManager
    {
        private List<Challenge> _challenges;

        public ChallengeManager()
        {
            _challenges = InitializeChallenges();
        }

        private List<Challenge> InitializeChallenges()
        {
            // Use the challenge.json file to initialize the challenges
            string json = File.ReadAllText("Challenges/challenges.json");
            return JsonConvert.DeserializeObject<List<Challenge>>(json);

        }

        public List<Challenge> GetChallenges()
        {
            return _challenges;
        }
    }
}
