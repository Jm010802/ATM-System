using System;
using System.Collections.Generic;
using System.Text;

namespace ATMDomain
{
    public class UserBankAccount
    {
        public long Id { get; set; }

        public long CardNumber { get; set; }

        public long CardPin { get; set; }

        public string FullName { get; set; }

        public long AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }

        public int TotalLogin { get; set; }

        public bool IsLocked { get; set; }
    }
}