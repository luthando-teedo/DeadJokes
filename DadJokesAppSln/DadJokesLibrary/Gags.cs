﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DadJokesLibrary
{
    
        public class Attachment
        {
            public string fallback { get; set; }
            public string footer { get; set; }
            public string text { get; set; }
        }

        public class DadGag
        {
            public List<Attachment> attachments { get; set; }
            public string response_type { get; set; }
            public string username { get; set; }
        }
    
}
