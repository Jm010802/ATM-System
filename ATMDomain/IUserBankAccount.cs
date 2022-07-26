using System;
using System.Collections.Generic;
using System.Text;

namespace ATMDomain
{
    public interface IUserBankAccount
    {
        void CheckBalance();
        void PlaceDeposit();
        void MakeWithdrawal();
    }
}