using System.Collections;

namespace lists;

class Program
{
    static void Main()
    {
        // ArrayList vehicles = [];
        List<Vehicle> vehicles = [];
        vehicles.Add(new Vehicle());

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