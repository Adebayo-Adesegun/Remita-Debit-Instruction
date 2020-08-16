using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Models.Requests
{

    public class DebitNotification
    {
        public string notificationType { get; set; }
        public List<Lineitems> lineItems { get; set; }
    }

    public class Lineitems
    {
        public string mandateId { get; set; }
        public string debitDate { get; set; }
        public string requestId { get; set; }
        public string setupRequestId { get; set; }
        public string amount { get; set; }
    }

}
