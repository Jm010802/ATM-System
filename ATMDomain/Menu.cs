﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ATMDomain
{
    public enum SecureMenu
    {
        // Value 1 is needed because menu starts with 1 while enum starts with 0 if no value given.

        [Description("Check balance")]
        CheckBalance = 1,

        [Description("Place Deposit")]
        PlaceDeposit = 2,

        [Description("Make Withdrawal")]
        MakeWithdrawal = 3,

        [Description("Third Party Transfer")]
        ThirdPartyTransfer = 4,

        [Description("Transaction")]
        ViewTransaction = 5,

        [Description("Logout")]
        Logout = 6
    }
}