namespace ATM;

using static BankAccount;


class Program
{
    static void Main()
    {
        // This try-catch block will handle any exceptions that may occur during the
        // execution of the program
        try
        {
            // Creates a new bank account instance and assigns it to the variable myAccount
            BankAccount myAccount = new();

            // Displays the balance of the bank account using the DisplayBalance method from
            // the BankAccount class
            DisplayBalance(myAccount);

            // Queries the user for how much they would like to deposit into the account
            Console.WriteLine("How much would you like to deposit? ");
            // Reads the user input and converts it into an integer
            int amount = int.Parse(Console.ReadLine()!);
            // Deposits the amount that was received into the account
            myAccount.Deposit(amount);

            DisplayBalance(myAccount);

            // Queries the user for how much they would like to withdraw from the account
            Console.WriteLine("How much would you like to withdraw? ");
            // Reads the user input and converts it into an integer
            amount = int.Parse(Console.ReadLine()!);
            // Withdraws the amount that was requested from the account, 
            // if sufficient funds are available
            myAccount.Withdraw(amount);

            DisplayBalance(myAccount);

            // List all transactions
            var currentTransactions = myAccount.DisplayTransactions();

            // Iterate through currentTransactions and write all of them to the console
            foreach (var transaction in currentTransactions)
            {
                Console.WriteLine($"Withdrawal: -{transaction}");
            }
        }

        // Catch any exceptions that occur during the execution of the program and
        // display an error message
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Something went wrong. Please try again, {ex.Message}");
        }
    }
}