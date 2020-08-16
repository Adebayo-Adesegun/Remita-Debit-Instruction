using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Models.Requests
{
    public class SendDebitInstruction
    {
        public string merchantId { get; set; }
        public string serviceTypeId { get; set; }
        public string hash { get; set; }
        public string requestId { get; set; }
        public string totalAmount { get; set; }
        public string mandateId { get; set; }
        public string fundingAccount { get; set; }
        public string fundingBankCode { get; set; }
    }

}
