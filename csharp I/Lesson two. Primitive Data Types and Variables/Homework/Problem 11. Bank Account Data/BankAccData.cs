using System;

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, 
//IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and
//descriptive names.

class BankAccData
{
    static void Main()
    {
        string firstName = "Peter";
        string middleName = "Georgiev";
        string lastName = "Ivanov";
        decimal balance = 3141599793.23M;
        string bankName = "Korporate commercial bank";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        long card1 = 4532549476011916;
        long card2 = 4024007170939564;
        long card3 = 4024007151073425;

        Console.Write("Name: " + firstName + " " + middleName  + " " + lastName + "\n");
        Console.WriteLine("Money available: " + balance + " euro");
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("Credit card numbers:\n" + "{0}\n" + "{1}\n" + "{2}", card1, card2, card3);
    }
}
