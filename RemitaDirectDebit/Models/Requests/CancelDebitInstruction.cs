using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Models.Requests
{
    public class CancelDebitInstruction
    {
        public string merchantId { get; set; }
        public string mandateId { get; set; }
        public string hash { get; set; }
        public string transactionRef { get; set; }
        public string requestId { get; set; }

    }
}
