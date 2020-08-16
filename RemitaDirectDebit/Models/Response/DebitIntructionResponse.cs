using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Models.Response
{
    public class DebitIntructionResponse
    {
        public string statuscode { get; set; }
        public string RRR { get; set; }
        public string requestId { get; set; }
        public string mandateId { get; set; }
        public int transactionRef { get; set; }
        public string status { get; set; }
    }
}
