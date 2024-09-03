namespace simpleClass;
using System.Collections;
class Program
{
    static void Main()
    {
        var myAccount = new BankAccount();

        // Show the current account balance
        Console.WriteLine("Current Bank Account Balance: {0}", myAccount.ShowBalance());

        myAccount.Deposit(100);

        // Show the current account balance
        Console.WriteLine("Current Bank Account Balance: {0}", myAccount.ShowBalance());

        // Try to catch an error
        try
        {
        myAccount.Withdraw(50);
        }

        // Catch and print any exceptions that may occur during the withdrawal process
        catch(Exception ex)
        {
            // Show the error message
            Console.WriteLine("An error occurred: {0}", ex.Message);
        }

        //  Show the current account balance
        Console.WriteLine("Current Bank Account Balance: {0}", myAccount.ShowBalance());

        // Show all transactions made to and from the account
        Console.WriteLine("All Transactions {0}", myAccount.ShowTransactions());
        Console.WriteLine("All Transactions");
        Console.WriteLine("---------------------");

        // For each loop to iterate through all the transactions and displays them
        var transactions = myAccount.ShowTransactions();
        foreach(var transaction in transactions)
        {
            Console.WriteLine("Transaction value: {0}", transaction);
        }
    }
}

public class BankAccount
{
    // Using double as opposed to int like my teacher to accommodate for potential decimal places in the balance
    // Created an information handler
    double balance = 0;

    // Dynamic array to log all withdrawals and deposits made to and from an account
    // Using [] instead of new ArrayList() because it looks cleaner
    ArrayList transactions = [];

    // A method to deposit money into the account
    public void Deposit(double value)
    {
        balance += value;
    }

    // A method to withdraw money from the account
    public void Withdraw(double value)
    {
        // If the amount of money in the account is less than the amount that is requested to be withdrawn throw an error, else proceed to the withdrawal
        if(balance < value)
        {
            // Throw an exception with a custom error message
            throw new Exception("Not enough money in your account to withdraw the requested amount");
        }
        else
        {
            // Subtract the withdrawn amount from the account balance and add the transaction to the list of transactions
            balance -= value;
            transactions.Add(value);
        }
    }

    // A method to show the current account balance
    public double ShowBalance()
    {
        return balance;
    }

    // A method to show all transactions made to and from the account
    public ArrayList ShowTransactions()
    {
        return transactions;
    }
}