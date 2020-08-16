using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Models.Response
{
    public class MandateStatusResponse
    {
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string requestId { get; set; }
        public string mandateId { get; set; }
        public string registrationDate { get; set; }
        public string isActive { get; set; }
    }
}
