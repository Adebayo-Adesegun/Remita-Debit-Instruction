﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Models.Response
{
    public class MandateSetupResponse
    {
        public string statuscode { get; set; }
        public string requestId { get; set; }
        public string mandateId { get; set; }
        public string status { get; set; }
    }
}
