﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAC_Web_Application.Services
{
    public class AuthMessageSenderOptions
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }

        public string TwilioUrl { get; set; }
        public string TwilioId { get; set; }
        public string TwilioToken { get; set; }
        public string TwilioPhoneNumber { get; set; }
    }
}
