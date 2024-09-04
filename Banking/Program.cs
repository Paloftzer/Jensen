﻿namespace Banking;
using static BankAccount;

class Program
{
    static void Main()
    {
        BankAccount myAccount = new();
        myAccount.AccountNumber = "ABC123";

        myAccount.Deposit(500);

        DisplayBalance(myAccount);

        myAccount.Deposit(700);

        DisplayBalance(myAccount);

        try
        {
            myAccount.Withdraw(0);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Something went wrong. Please try again. Error: {ex.Message}");
        }

        DisplayBalance(myAccount);

        Console.WriteLine(myAccount.ToString());
    }
}