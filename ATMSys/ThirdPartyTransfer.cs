using System;
using System.Collections.Generic;
using System.Text;

namespace ATMSys
{
    public class ThirdPartyTransfer
    {
        public decimal TransferAmount { get; set; }
        public long RecipientBankAccountNumber { get; set; }
        public string RecipientBankAccountName { get; set; }
    }
}