using System;
using System.Collections.Generic;
using System.Text;

namespace betuapp.Shared
{
    public class Bet
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Evidence { get; set; }

        public DateTime DueDate { get; set; }

        public long Tip { get; set; }


        public bool ChallengerWon { get; set; }
        public bool IstAbgeschlossen { get; set; }
        public bool ConsentChallengedGiven { get; set; }
        public bool ConsentChallengerGiven { get; set; }

        public bool ChallengerWonChallenger { get; set; }
        public bool ChallengerWonChallenged { get; set; }
        public long ChallengerId { get; set; }
        public long ChallengedId { get; set; }


    }
}
