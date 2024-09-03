namespace Stacks;

class Program
{
    static void Main()
    {
        Stack<string> vehicles = new();
        vehicles.Push("Volvo");
        vehicles.Push("Ford");
        vehicles.Push("KIA");
        vehicles.Push("Fiat");
        vehicles.Push("Tesla");

        while(vehicles.Count > 0)
        {
            Console.WriteLine($"Manufacturer: {vehicles.Pop()}");
        }

        foreach(var vehicle in vehicles)
        {
            Console.WriteLine($"Manufacturer : {vehicle}");
        }
    }
}
