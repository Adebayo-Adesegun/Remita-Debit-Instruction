using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Models.Response
{
    public class DebitStatusResponse
    {
        public string statuscode { get; set; }
        public string amount { get; set; }
        public string RRR { get; set; }
        public string requestId { get; set; }
        public string mandateId { get; set; }
        public string transactionRef { get; set; }
        public string lastStatusUpdateTime { get; set; }
        public string status { get; set; }
    }
}
