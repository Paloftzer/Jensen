using System.Collections;

namespace ATM;

public class BankAccount
{
    // Instance variable to hold the account balance
    int balance = 0;

    // List of type integer to store all transactions made on the account
    List<int> transactions = [];

    // Method to deposit funds into the account
    public void Deposit(int amount)
    {
        balance += amount;
    }

    // Method to withdraw funds from the account
    public void Withdraw(int amount)
    {
        // Check if there are enough funds in the account to complete the withdrawal
        if (balance >= amount)
        {
            // If there are enough funds, subtract the requested withdrawal amount
            // from the account balance
            balance -= amount;
            // Logs the transaction amount and stores it in the List
            transactions.Add(amount);
        }
        else
        {
            // If the balance of the account is less than the requested withdrawal amount,
            // display an error message
            throw new ArgumentException("Insufficient funds.");
        }
    }

    // Static method to display the current balance of a BankAccount instance
    public static void DisplayBalance(BankAccount Account)
    {
        // Retrieve the balance directly inside this method
        int balance = Account.balance;

        // The $ before the quotes functions roughly the same as writing {0} and declaring
        // the variable after the quotes ex. Console.WriteLine("Your current balance is : {0}", myBalance)
        // except it lets us put the variable name directly into the {}
        // Logs to the console the current balance of the account
        Console.WriteLine($"Your current balance is: {balance}");
    }

    // Method to display a list of the current transactions made on the account
    public List<int> DisplayTransactions()
    {
        // Returns the List of transactions made on the account
        return transactions;
    }
}