﻿using System;
using System.Collections.Generic;
using System.Text;

namespace betuapp.Shared
{
    public class LoginParameters
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}