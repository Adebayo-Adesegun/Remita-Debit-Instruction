using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Models.Response
{
    public class MandatePaymentHistoryResponse
    {
        public string statuscode { get; set; }
        public Data data { get; set; }
        public string requestId { get; set; }
        public string mandateId { get; set; }
        public string status { get; set; }
    }

    public class Data
    {
        public Data2 data { get; set; }
    }

    public class Data2
    {
        public int totalTransactionCount { get; set; }
        public double totalAmount { get; set; }
        public List<PaymentDetail> paymentDetails { get; set; }
    }

    public class PaymentDetail
    {
        public string amount { get; set; }
        public string lastStatusUpdateTime { get; set; }
        public string status { get; set; }
        public string statuscode { get; set; }
        public string RRR { get; set; }
        public string transactionRef { get; set; }
    }
}
