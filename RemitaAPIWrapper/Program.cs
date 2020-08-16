using System;
using RemitaAPIWrapper.Models.Requests;
using RemitaDirectDebit;

namespace RemitaAPIWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            RemitaHttpClient remita = new RemitaHttpClient("27768931", "35126630", "Q1dHREVNTzEyMzR8Q1dHREVNTw==");

            SetupMandate mandate = new SetupMandate
            {
                amount = "1000.00",
                payerAccount = "1234890001",
                endDate = "03/07/2020",
                startDate = "30/07/2020",
                maxNoOfDebits = "1",
                payerName = "John Doe",
                payerEmail = "segibambo@gmail.com",
                payerBankCode = "057",
                payerPhone = "07066576295"
            };

            var result = remita.SetUpMandateStandingOrder(mandate).Result;


        }
    }
}
