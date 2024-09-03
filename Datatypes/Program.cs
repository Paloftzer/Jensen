namespace Datatypes;

class Program
{
    static void Main()
    {
        // Initializes a new object and prints its hash code and type
        object obj = new();
        Console.WriteLine("---- Object ----");
        Console.WriteLine($"GetHashCode: {obj.GetHashCode()}");
        Console.WriteLine($"Type: {obj.GetType()}");

        // Initializes an integer and prints its hash code, type, comparison to 20
        // and its string representation
        int x = 10;
        Console.WriteLine("---- Integer ----");
        Console.WriteLine($"GetHashCode: {x.GetHashCode()}");
        Console.WriteLine($"GetType: {x.GetType()}");
        Console.WriteLine($"CompareTo: {x.CompareTo(20)}");
        Console.WriteLine($"ToString: {x.ToString()}");

        // Initializes a string and prints its hash code and type
        string name = "Paloftzer The Fifth";
        Console.WriteLine("---- String ----");
        Console.WriteLine($"GetHashCode: {name.GetHashCode()}");
        Console.WriteLine($"GetType: {name.GetType()}");

        // Replaces the substring "The Fifth" with "The Fourth" in the string
        string name2 = name.Replace("The Fifth", "The Fourth");
        Console.WriteLine($"Replace: {name2}");

        // string a = "a" + "b" + "c";
        // Concatenates multiple strings with spaces in between into a single string
        string concatName = string.Concat("Banana"," ", "The"," ", "Eighty-third");
        Console.WriteLine($"Concat: {concatName}");

        // Initializes a DateTime object and prints its current date and time
        DateTime myDate = DateTime.Now;
        Console.WriteLine("---- DateTime ----");
        Console.WriteLine($"Current Date and time: {myDate}");
        Console.WriteLine($"Current Date: {myDate.Date}");
        Console.WriteLine($"Current Time: {myDate.TimeOfDay}");
        Console.WriteLine($"Current Date and time +1 day: {myDate.AddDays(1)}");
        Console.WriteLine($"Current Date and time -1 day: {myDate.AddDays(-1)}");
        Console.WriteLine($"Current Date and time +6 months: {myDate.AddMonths(6)}");
        Console.WriteLine($"Current Date and time -6 months: {myDate.AddMonths(-6)}");
        Console.WriteLine($"Current Date and time +2 years: {myDate.AddYears(2)}");
        Console.WriteLine($"Current Date and time -2 years: {myDate.AddYears(-2)}");
        Console.WriteLine($"Current year: {myDate.Year}");
        Console.WriteLine($"Current Month: {myDate.Month}");
        Console.WriteLine($"Current Day of the month: {myDate.Day}");
        Console.WriteLine($"Current Day of the week: {myDate.DayOfWeek}");
        Console.WriteLine($"Current Day of the year: {myDate.DayOfYear}");
        Console.WriteLine($"Days remaining in the year: {365 - myDate.DayOfYear}");
        
        //
    }
}
