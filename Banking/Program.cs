namespace Banking;
using static BankAccount;

class Program
{
    static void Main()
    {
        BankAccount myAccount = new();
        myAccount.AccountNumber = "ABC123";
        // Console.WriteLine($"Your account number is: {myAccount.AccountNumber()}");
        Console.WriteLine("Your account number is: {0}", myAccount.AccountNumber);

        BankAccount secondAccount = new("XYZ789");
        BankAccount thirdAccount = new(500,"XYZ789");

        myAccount.Deposit(500);

        // GetBalance(myAccount);

        myAccount.Deposit(700);

        // GetBalance(myAccount);

        try
        {
            myAccount.Withdraw(0);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Something went wrong. Please try again. Error: {ex.Message}");
        }

        // GetBalance(myAccount);

        Console.WriteLine(myAccount.ToString());
    }
}