using ATMSys;
using ATMLib;
using ATMDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMSys
{
    internal class Screen
    {
        // This class in charge of printing out text in user interface.

        internal const string currency = "PHP ";

        internal static void WelcomeATM()
        {
            Console.Clear();
            Console.Title = "PUP Biñan ATM System.";
            Console.WriteLine("Welcome to PUP Biñan ATM.\n");
            Console.WriteLine("Please insert your ATM card.", Console.ForegroundColor = ConsoleColor.Cyan);
            Console.ResetColor();
            Utility.PrintEnterMessage();
        }

        internal static void WelcomeCustomer(string fullName)
        {
            Utility.PrintConsoleWriteLine("Welcome back, " + fullName);
        }


        internal static void PrintLockAccount()
        {
            Console.Clear();
            Utility.PrintMessage("Your account is locked. Please go to " +
                "the nearest branch to unlocked your account. Thank you.", true);
            Utility.PrintEnterMessage();
            Environment.Exit(1);
        }

        internal UserBankAccount LoginForm()
        {
            var vmUserBankAccount = new UserBankAccount();

            // Actual ATM system will accept and validate physical ATM card.
            // Card validation includes read card number and check bank account status
            // and other security checking.

            vmUserBankAccount.CardNumber = Validator.Convert<long>("card number");

            vmUserBankAccount.CardPin = Convert.ToInt32(Utility.GetHiddenConsoleInput("Enter card pin: "));

            return vmUserBankAccount;
        }

        internal static void LoginProgress()
        {
            Console.Write("\nChecking card number and card pin.");
            Utility.printDotAnimation();
            Console.Clear();
        }

        internal static void LogoutProgress()
        {
            Console.WriteLine("Thank you for using PUP Biñan ATM system.");
            Utility.printDotAnimation();
            Console.Clear();
        }


        internal static void DisplaySecureMenu()
        {
            Console.Clear();
            Console.WriteLine(" ---------------------------");
            Console.WriteLine("| PUP Biñan ATM Secure Menu  |");
            Console.WriteLine("|                            |");
            Console.WriteLine("| 1. Balance Enquiry         |");
            Console.WriteLine("| 2. Cash Deposit            |");
            Console.WriteLine("| 3. Withdrawal              |");
            Console.WriteLine("| 4. Third Party Transfer    |");
            Console.WriteLine("| 5. Transactions            |");
            Console.WriteLine("| 6. Logout                  |");
            Console.WriteLine("|                            |");
            Console.WriteLine(" ---------------------------");

        }

        internal static void PrintCheckBalanceScreen()
        {
            Console.Write($"Account balance amount: ");
        }

        internal ThirdPartyTransfer ThirdPartyTransferForm()
        {
            var ThirdPartyTransfer = new ThirdPartyTransfer();

            ThirdPartyTransfer.RecipientBankAccountNumber = Validator.Convert<long>("recipient's account number");
        
            ThirdPartyTransfer.TransferAmount = Validator.Convert<decimal>($"amount {currency}");

            ThirdPartyTransfer.RecipientBankAccountName = Utility.GetRawInput("recipient's account name");

            return ThirdPartyTransfer;
        }
    }
}
