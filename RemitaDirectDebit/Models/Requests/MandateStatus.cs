using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Models.Requests
{
    public class MandateStatus
    {
        public string merchantId { get; set; }
        public string mandateId { get; set; }
        public string hash { get; set; }
        public string requestId { get; set; }
    }
}
