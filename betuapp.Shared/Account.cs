﻿namespace betuapp.Shared
{
    public class Account
    {
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public long OwnedCash { get; set; }
        public string Password { get; set; }
    }  
}
