using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Models.Requests
{
    public class MandateActivateValidateOtp
    {
        public string remitaTransRef { get; set; }
        public List<Authparam> authParams { get; set; }
    }

    public class Authparam
    {
        public string param1 { get; set; }
        public string value { get; set; }
        public string param2 { get; set; }
    }
}
