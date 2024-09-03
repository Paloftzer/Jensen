using Microsoft.VisualBasic;

namespace simpleATM;
class Program
{
    static void Main()
    {
        // Declare a variable to store the balance
        int balance;

        // Query the user for the amount to be deposited
        Console.WriteLine("Input deposit amount: ");

        // Reads the input to get the amount deposited by the user
        var deposit = Console.ReadLine()!;
        // Adds the deposited amount to the balance
        balance = int.Parse(deposit);

        // Calls the DisplayBalance method and displays the current balance of the account
        DisplayBalance(balance);

        // Query the user for the amount to be withdrawn, and then reads the input and logs it to the withdraw variable
        Console.WriteLine("Input withdrawal amount: ");
        var withdraw = Console.ReadLine()!;
        // Subtracts the withdrawn amount from the balance
        balance -= int.Parse(withdraw);

        // Calls the DisplayBalance method and displays the current balance of the account
        DisplayBalance(balance);
    }
    static void DisplayBalance(int balance)
    {
        // Displays the current balance of the account
        Console.WriteLine("Current balance: " + balance);
    }
}