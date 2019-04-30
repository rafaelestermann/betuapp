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
        public Account Challenger { get; set; }
        public Account Challenged { get; set; }
    }
}
