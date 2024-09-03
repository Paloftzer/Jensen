namespace Dictionaries;

class Program
{
    static void Main()
    {
        Dictionary<int, string> vehiclesInfo = [];

        vehiclesInfo.Add(1, "Volvo");
        vehiclesInfo.Add(2, "Ford");
        vehiclesInfo.Add(3, "KIA");

        var vehicle = vehiclesInfo[2];

        Console.WriteLine(vehicle);

        Dictionary<string, string> vehiclesInfo2 = [];

        vehiclesInfo2.Add("ABC123", "Volvo");
        vehiclesInfo2.Add("JGE401", "Ford");
        vehiclesInfo2.Add("PAU937", "KIA");

        var vehicle2 = vehiclesInfo2["ABC123"];

        Console.WriteLine(vehicle2);

        foreach(KeyValuePair<string,string> car in vehiclesInfo2)
        {
            Console.WriteLine($"License plate: {car.Key}, Model: {car.Value}");
        }
    }
}
