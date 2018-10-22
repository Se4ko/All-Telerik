using System;
/*
11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/
class BankAccountData
{
    static void Main()
    {
        string firstName = "Stoyan";
        string middleName = "Tsvetanov";
        string lastName = "Grigorov";
        string accountHolderName = firstName + " " + middleName + " " + lastName;
        decimal balance = 15234.36M;
        string bankName = "Societe Generale";
        string iban = "FR1420041010050500013M02606";
        ulong creditcard1 = 4797217878243731, creditcard2 = 5438338705809007, creditcard3 = 3444011920715907;

        //Test
        Console.WriteLine("Account holder: {0}", accountHolderName);
        Console.WriteLine("Account balance: {0}", balance);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit cards:\n{0}\n{1}\n{2}", creditcard1, creditcard2, creditcard3);
    }
}
