using System.Collections;

namespace lists;

class Program
{
    static void Main()
    {
        ArrayList vehicles = [];
        vehicles.Add(new Vehicle());
        vehicles.Add(new BankAccount());

        foreach(Vehicle car in vehicles)
        {
            Console.WriteLine(car);
        }
    }
}

public class Vehicle
{

}

public class BankAccount
{

}