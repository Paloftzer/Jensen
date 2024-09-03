namespace stringDemo;

class Program
{
    static void Main()
    {
        string name = "Jensen Education";
        Console.WriteLine(name);

        // Alternate version to name.Substring(5): name[5..]
        // Writes to the console starting from the fifth character and continues another 4 characters before stopping
        string character = name.Substring(5, 4);
        Console.WriteLine(character);

        // Splitting a string into an array of strings using a specific delimiter and then writing each element of the array to the console
        string[] words = name.Split(" ");
        Console.WriteLine(words[0]);
        Console.WriteLine(words[1]);

        // Basic Console.WriteLine
        double value = 7988.6795;
        Console.WriteLine("The value is: " + value);
        Console.WriteLine("The value is: " + value + "\n" + "The name is: " + name);

        // Template Strings using {0} and {1} to substitute the variables in the text
        Console.WriteLine("The value is: {0}\nThe name is {1}", value, name);

        // Formatting a double value with two decimal places using the :f2 format specifier
        Console.WriteLine("The value is: {0:f2}\nThe name is {1}", value, name);

        // Formatting a double value with two decimal places and a thousands separator using the :n2 format specifier
        Console.WriteLine("The value is: {0:n2}\nThe name is {1}", value, name);

        // List of format specifiers
        // :d - Decimal number
        // :f - Floating-point number
        // :n - Number with thousands separator
        // :x - Hexadecimal number
        // :c - Currency
        // :e - Scientific notation
        // :g - General number format
        // :o - Octal number
        // :u - Uppercase hexadecimal number
        // :s - String
    }
}
