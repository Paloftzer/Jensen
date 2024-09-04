namespace Banking;
using static BankAccount;

class Program
{
    static void Main()
    {
        BankAccount myAccount = new();
        myAccount.AccountNumber = "ABC123";
        Console.WriteLine($"Your account number is: {myAccount.AccountNumber}, the date of creation is: {myAccount.CreatedAt}");
        // Console.WriteLine("Your account number is: {0}, the date of creation is: {1}", myAccount.AccountNumber, myAccount.CreatedAt);

        BankAccount secondAccount = new("XYZ789");
        BankAccount thirdAccount = new(500,"XYZ789");

        myAccount.Deposit(500);
        
        Console.WriteLine($"Your current balance is: {myAccount.Balance}");
        // GetBalance(myAccount);

        myAccount.Deposit(700);

        Console.WriteLine($"Your current balance is: {myAccount.Balance}");
        // GetBalance(myAccount);

        try
        {
            myAccount.Withdraw(0);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Something went wrong. Please try again. Error: {ex.Message}");
        }

        Console.WriteLine($"Your current balance is: {myAccount.Balance}");
        // GetBalance(myAccount);

        Console.WriteLine(myAccount.ToString());
    }
}