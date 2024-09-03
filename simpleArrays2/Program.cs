namespace simpleArrays;
class Program
{
    static void Main()
    {
        // Array method 1
        int[] numbers = new int[100];

        // Add an integer to the array using its index, the first position in an array will always be [0], second position will be [1] and so on
        // Adds the number 1 to the first position in the array
        numbers[0] = 1;
        // Adds the number 2 to the second position in the array
        numbers[1] = 2;
        // Continued...

        Console.WriteLine("The value of the second position of the array: " + numbers[1]);

        // Array method 2
        int[] values = [1, 2, 3];


        Console.WriteLine("Current value in the array of values: " + values[2]);
    }
}
