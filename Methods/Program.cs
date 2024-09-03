namespace Methods;

class Program
{
    // Examples of method overloading, two methods with the same name
    // but different parameters
    static void Main()
    {
        MyMethod();
        MyMethod("Hello, World!");
        MyMethod(5);
        MyMethod("Hello, World!", 5);
        Console.WriteLine($"The sum is: {Sum(5, 10)}");
        Console.WriteLine($"The sum is: {Sum(5, 10, 305)}");
        Console.WriteLine($"The sum is: {Sum2([5, 10, 305, 86085, 5791560])}");

        Console.WriteLine("----------------");

        //! Part of the bad practice from below
        /* foreach(double value in CalculateBalance(250))
        {
            Console.WriteLine($"CalculatedBalance: {value}");
        } */

        double interest = 1.025;
        int balance = CalculateBalance(250, interest, out double calculatedBalance);
        Console.WriteLine($"Balance: {balance}, interest: {interest}, CalculatedBalance: {calculatedBalance}");
    }

    static void MyMethod()
    {
        Console.WriteLine("This method does nothing.");
    }

    static void MyMethod(string text)
    {
        Console.WriteLine($"This method takes a string parameter: {text}");
    }

    static void MyMethod(int number)
    {
        Console.WriteLine($"This method takes an integer parameter: {number}");
    }

    static void MyMethod(string text, int number)
    {
        Console.WriteLine($"This method takes two parameters: {text} and {number}");
    }

    static int Sum(int x, int y)
    {
        return x + y;
    }

    static int Sum(int x, int y, int z)
    {
        return x + y + z;
    }

    static int Sum2(int[] numbers)
    {
        int result = 0;

        foreach(int num in numbers)
        {
            result += num;
        }

        return result;
    }

    //! Bad practice for such a low number of returns
    /*
    static List<Double> CalculateBalance(double balance)
    {
        double interest = balance * 1.05;
        // List<Double> results = new List<Double>();
        // List<Double> results = new();
        List<Double> results = [];
        results.Add(balance);
        results.Add(interest);

        return results;
    } */

    static int CalculateBalance(int balance, double interest, out double calculatedBalance)
    {
        calculatedBalance = balance * interest;
        return balance;
    }
}