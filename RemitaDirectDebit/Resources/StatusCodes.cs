using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Resources
{

    public class StatusCodes
    {

        public string Name { get; set; }
        public string Code { get; set; }


        public List<StatusCodes> StatusCodesList()
        {
            return new List<StatusCodes>
            {
                new StatusCodes { Name = "New Transaction", Code = "069"},
                new StatusCodes { Name = "Awaiting Debit", Code = "070" },
                new StatusCodes { Name = "Undergoing Bank Processing", Code = "071" },
                new StatusCodes { Name = "Pending Credit", Code = "072" },
                new StatusCodes { Name = "Invalid Mandate Type", Code = "073" },
                new StatusCodes { Name = "No Available Record", Code = "074" },
                new StatusCodes { Name = "Transaction Completed Successfully", Code = "00" },
                new StatusCodes { Name = "Approved", Code = "01" },
                new StatusCodes { Name = "Mandate Already Active", Code = "075" },
                new StatusCodes { Name = "Mandate Deactivated", Code = "066" },
                new StatusCodes { Name = "Only Direct Debit Mandate Allowed", Code = "067" },
                new StatusCodes { Name = "Invalid Hash Value", Code = "013" },
                new StatusCodes { Name = "Invalid Mandate", Code = "061" },
                new StatusCodes { Name = "Mandate Not Due", Code = "062" },
                new StatusCodes { Name = "Expired Mandate", Code = "063" },
                new StatusCodes { Name = "Authentication Error", Code = "020" },
                new StatusCodes { Name = "Initial Request OK", Code = "069" },
            };
        }
    }
}
