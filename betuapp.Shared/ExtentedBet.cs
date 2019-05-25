using System;
using System.Collections.Generic;
using System.Text;

namespace betuapp.Shared
{
    public class ExtentedBet
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Evidence { get; set; }

        public DateTime DueDate { get; set; }

        public long Tip { get; set; }

        public bool IstAbgeschlossen { get; set; }

        public bool ChallengerWon { get; set; }
        public bool ConsentChallenger { get; set; }

        public bool ConsentChallenged { get; set; }
        public Account Challenger { get; set; }
        public Account Challenged { get; set; }


    }
}
