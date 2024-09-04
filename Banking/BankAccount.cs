namespace Banking;

public class BankAccount
{
    // Declare the information that should be stored in the object
    private decimal _balance;
    private readonly decimal _interestRate;
    public string AccountNumber;

    // Constructor method
    public BankAccount()
    {
        _balance = 0.00m;
        _interestRate = 1.025m;
        AccountNumber = "";
    }

    // Overloaded constructors
    public BankAccount(string accountNumber)
    {
        _balance = 0.00m;
        _interestRate = 1.025m;
        AccountNumber = accountNumber;
    }

    public BankAccount(decimal initialBalance, string accountNumber)
    {
        _balance = initialBalance;
        _interestRate = 1.025m;
        AccountNumber = accountNumber;
    }

    // Methods
    public void Deposit(int amount)
    {
        _balance += amount;

        if (_balance >= 1000)
        {
            _balance *= _interestRate;
        }
    }

    public void Withdraw(int amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
        }
        else
        {
            throw new ArgumentException("Insufficient funds to withdraw.");
        }
    }

    public static void DisplayBalance(BankAccount account)
    {
        decimal balance = account._balance;
        decimal interestRate = account._interestRate;

        if (balance >= 1000)
        {
            Console.WriteLine($"Your current balance is: {balance}\nYour current interest rate is: {interestRate}");
        }
        else 
        {
            Console.WriteLine($"Your current balance is: {balance}");
        }
    }

    public override string ToString()
    {
        return $"Account Number: {AccountNumber}\nBalance: {_balance}";
    }
}
