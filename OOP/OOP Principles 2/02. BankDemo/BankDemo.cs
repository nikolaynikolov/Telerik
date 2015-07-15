using Bank;
using System;
using System.Globalization;
using System.Threading;

class BankDemo
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        Customer depositAccountCustomer = new IndividualCustomer(
            "123456789AA",
            "Pesho",
            "Peshov",
            "Sofia, Bulgaria, Tzarigradsko shose 2",
            "555-123-123");

        DepositAccount depositAccount = new DepositAccount(
            depositAccountCustomer,
            2000,
            0.1234M,
            36);

        Customer loanAccountCustomer = new CorporateCustomer(
            "123456789AB",
            "Oracle Corporation",
            "Sofia, Bulgaria, Tzarigradsko shose 20",
            "555-123-321");

        Account loanAccount = new LoanAccount(
            loanAccountCustomer,
            9000000000,
            0.1234M,
            24);

        Customer mortgageLoanAccountCustomer = new IndividualCustomer(
            "223456789AA",
            "Ginni",
            "Rometty",
            "Sofia, Bulgaria, Tzarigradsko shose 22",
            "555-321-321");

        Account mortgageLoanAccount = new MortgageLoanAccount(
            mortgageLoanAccountCustomer,
            990000,
            0.1234M,
            12);

        decimal depositInterest = depositAccount.CalculateInterest(3);
        Console.WriteLine("Deposit account interest: {0:C2}", depositInterest);

        depositAccount.Deposit(459.76M);
        depositAccount.Withdraw(400.76M);

        Console.WriteLine("Deposit account balance: {0:C2}", depositAccount.Balance);

        decimal loanInterest = loanAccount.CalculateInterest(10);
        Console.WriteLine("Loan account interest: {0:C2}", loanInterest);

        decimal mortgageLoanInterest = mortgageLoanAccount.CalculateInterest(10);
        Console.WriteLine("Mortgage loan account interest: {0:C2}", mortgageLoanInterest);
    }
}
