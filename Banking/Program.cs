namespace Banking;
using static BankAccount;

class Program
{
    static void Main()
    {
        BankAccount myAccount = new("ABC123");

        BankAccount secondAccount = new("XYZ789");
        BankAccount thirdAccount = new(500,"XYZ789");

        myAccount.Deposit(500);

        GetBalance(myAccount);

        myAccount.Deposit(700);

        GetBalance(myAccount);

        try
        {
            myAccount.Withdraw(0);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Something went wrong. Please try again. Error: {ex.Message}");
        }

        GetBalance(myAccount);

        Console.WriteLine(myAccount.ToString());
    }
}