using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Models.Requests
{
    public class MandateActivateRequestOtp
    {
        public string mandateId { get; set; }
        public string requestId { get; set; }
    }
}
