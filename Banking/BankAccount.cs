namespace Banking;

public class BankAccount
{
    // Declare the information that should be stored in the object
    private decimal _balance;
    private readonly decimal _interestRate;
    private string _accountNumber;

    // Properties
    public string AccountNumber
    {
        get { return _accountNumber;}
        set { _accountNumber = value; }
    }

    public decimal Balance
    {
        get { return _balance; }
    }

    public decimal InterestRate
    {
        get { return _interestRate; }
    }
    
    // Getters and setters

    // Getter
    /* public static void GetBalance(BankAccount account)
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

    // Getter
    public decimal GetInterestRate()
    {
        return _interestRate;
    }

    // Getter
    public string GetAccountNumber()
    {
        return _accountNumber;
    }

    // Setter
    public void SetAccountNumber(string accountNumber)
    {
        _accountNumber = accountNumber;
    } */

    // Constructor method
    public BankAccount()
    {
        _balance = 0.00m;
        _interestRate = 1.025m;
        _accountNumber = "";
    }

    // Overloaded constructors
    public BankAccount(string accountNumber)
    {
        _balance = 0.00m;
        _interestRate = 1.025m;
        _accountNumber = accountNumber;
    }

    public BankAccount(decimal initialBalance, string accountNumber)
    {
        _balance = initialBalance;
        _interestRate = 1.025m;
        _accountNumber = accountNumber;
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

    public override string ToString()
    {
        return $"Account Number: {_accountNumber}\nBalance: {_balance}";
    }
}
