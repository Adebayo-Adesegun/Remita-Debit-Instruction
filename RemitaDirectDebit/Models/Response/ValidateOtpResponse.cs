using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Models.Response
{
    public class ValidateOtpResponse
    {
        public string statuscode { get; set; }
        public string mandateId { get; set; }
        public string status { get; set; }
    }
}
