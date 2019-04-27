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
        public long Challenger { get; set; }
        public long? Challenged { get; set; }
    }
}
