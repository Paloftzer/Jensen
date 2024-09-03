namespace simpleArrays;
class Program
{
    static void Main()
    {
        try
        {
            // Throwing an exception
            throw new Exception("An error occurred!");
            // Array method 1
            int[] numbers = new int[5];

            // Add an integer to the array using its index, the first position in an array will always be [0], second position will be [1] and so on
            // Adds the number 1 to the first position in the array
            numbers[0] = 1;
            // Adds the number 2 to the second position in the array
            numbers[1] = 2;
            // Adds the number 3 to the third position in the array
            numbers[2] = 3;
            // Adds the number 4 to the fourth position in the array
            numbers[3] = 4;
            // Adds the number 5 to the fifth position in the array
            numbers[4] = 5;
            // Trying to add another element to the array causes an IndexOutOfRangeException
            // numbers[5] = 6;

            Console.WriteLine("The value of the second position of the array: " + numbers[1]);

            // Array method 2
            int[] values = [1, 2, 3];

            Console.WriteLine("Current value in the array of values: " + values[2]);

            // Array with strings
            string[] Vehicles = new string[5];
            string[] vehicles2 = ["Volvo", "Ford", "KIA"];

            // Array with objects
            object[] queries = [
            new{query="Question 1", answer="Answer to question 1"},
            new{query="Question 2", answer="Answer to question 2"},
            new{query="Question 3", answer="Answer to question 3"}
            ];

            // Array methods
            Console.WriteLine("Number of elements in vehicles2: " + vehicles2.Length);
            Console.WriteLine("First car in vehicles2: " + vehicles2.First());
            Console.WriteLine("Last car in vehicles2: " + vehicles2.Last());
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Done");
        }
    }
}