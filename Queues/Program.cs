namespace Queues;

class Program
{
    static void Main()
    {
        Queue<string> vehicles = [];
        vehicles.Enqueue("Volvo");
        vehicles.Enqueue("Ford");
        vehicles.Enqueue("KIA");
        vehicles.Enqueue("Fiat");
        vehicles.Enqueue("Tesla");

        while(vehicles.Count > 0)
        {
            Console.WriteLine($"Manufacturer: {vehicles.Dequeue()}");
        }

        foreach(var vehicle in vehicles){
            Console.WriteLine($"Manufacturer: {vehicle}");
        }
    }
}
