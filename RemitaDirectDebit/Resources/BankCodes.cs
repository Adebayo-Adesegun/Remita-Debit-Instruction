using System;
using System.Collections.Generic;
using System.Text;

namespace RemitaAPIWrapper.Resources
{
    public class BankCodes
    {
        private string BankName { get; set; }
        private string BankCode { get; set; }


        public List<BankCodes> BankCodesList()
        {
            return new List<BankCodes>
            {
                new BankCodes { BankName = "CITIBANK NIG LTD", BankCode = "023"},
                new BankCodes { BankName = "FIRST CITY MONUMENT BANK PLC", BankCode = "214" },
                new BankCodes { BankName = "FIRST BANK OF NIGERIA PLC", BankCode = "011" },
                new BankCodes { BankName = "WEMA BANK PLC", BankCode = "035" },
                new BankCodes { BankName = "STANBIC IBTC BANK PLC", BankCode = "039" },
                new BankCodes { BankName = "UBA PLC", BankCode = "033" },
                new BankCodes { BankName = "PROVIDUS BANK PLC", BankCode = "101" },
                new BankCodes { BankName = "ACCESS BANK PLC", BankCode = "044" },
                new BankCodes { BankName = "ECOBANK NIGERIA PLC", BankCode = "050" },
                new BankCodes { BankName = "ZENITH BANK PLC", BankCode = "057" },
                new BankCodes { BankName = "DIAMOND BANK PLC", BankCode = "063" },
                new BankCodes { BankName = "SKYE BANK PLC", BankCode = "076" },
                new BankCodes { BankName = "KEYSTONE BANK", BankCode = "082" },
                new BankCodes { BankName = "STERLING BANK PLC", BankCode = "232" },
                new BankCodes { BankName = "UNION BANK OF NIGERIA PLC", BankCode = "032" },
                new BankCodes { BankName = "HERITAGE BANK", BankCode = "030" },
                new BankCodes { BankName = "JAIZ BANK PLC", BankCode = "301" },
                new BankCodes { BankName = "GUARANTY TRUST BANK PLC", BankCode = "058"},
                new BankCodes { BankName = "FIDELITY BANK PLC", BankCode = "070" },
                new BankCodes { BankName = "STANDARD CHARTERED BANK NIGERIA LTD", BankCode = "068" },
                new BankCodes { BankName = "SUNTRUST BANK NIG LTD", BankCode = "100" },
                new BankCodes { BankName = "UNITY BANK PLC", BankCode = "215" },

            };
        }

    }
}
