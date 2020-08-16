using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Models.Requests
{


    public class ActivationNotification
    {
        public string notificationType { get; set; }
        public Lineitem[] lineItems { get; set; }
    }

    public class Lineitem
    {
        public string mandateId { get; set; }
        public string activationDate { get; set; }
        public string requestId { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string amount { get; set; }
    }
}
