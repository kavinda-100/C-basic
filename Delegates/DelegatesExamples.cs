namespace Program.Delegates;

public class DelegatesExamples
{
    // Define a delegate type named Callback that takes an int and returns a bool
    delegate bool Callback(int x);

    // Method to filter a list of integers based on a callback function
    private List<int> Filter(List<int> numbers, Callback callback)
    {
        var result = new List<int>();

        // Iterate through each number in the list
        foreach (var number in numbers)
        {
            // If the callback function returns true, add the number to the result list
            if(callback(number))
            {
                result.Add(number);
            }
        }

        return result;
    }

    // Callback function to check if a number is even
    private bool IsEven(int x) => x % 2 == 0;

    // Callback function to check if a number is odd
    private bool IsOdd(int x) => x % 2 != 0;

    // Method to run the example
    public void Run()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Filter the list to get even numbers using the IsEven callback
        var evenNumbers = Filter(numbers, IsEven);
        // Filter the list to get odd numbers using the IsOdd callback
        var oddNumbers = Filter(numbers, IsOdd);

        // Print the even numbers
        Console.WriteLine("Even numbers:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }

        // Print the odd numbers
        Console.WriteLine("Odd numbers:");
        foreach (var number in oddNumbers)
        {
            Console.WriteLine(number);
        }
    }
}