﻿namespace Program.List_and_ArrayList;

public class ListExample
{
    // List is a generic type, so we need to specify the type of the elements
    public static void Run()
    {
        List<int> numbers = new List<int>();
        
        //all the methods of the List class are available in the ListExample class

        // Add elements to the list
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);

        // Access elements by index
        Console.WriteLine(numbers[0]); // 1
        Console.WriteLine(numbers[1]); // 2
        Console.WriteLine(numbers[2]); // 3
        Console.WriteLine(numbers[3]); // 4
        Console.WriteLine(numbers[4]); // 5

        // Update elements by index
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        // Remove elements by index
        numbers.RemoveAt(0);
        numbers.RemoveAt(1);
        numbers.RemoveAt(2);
        
        // find the index of an element
        int index = numbers.IndexOf(40);
        Console.WriteLine($"index of 40 is: {index}"); // 1
        
        // Check if an element exists in the list
        bool exists = numbers.Contains(40);
        Console.WriteLine($"is 40 exists: {exists}"); // true
        
        // Get the number of elements in the list
        int count = numbers.Count;
        Console.WriteLine($"count: {count}"); // 2
        
        // Insert an element at a specific index
        numbers.Insert(0, 100);
        
        // Remove an element by value
        numbers.Remove(40);
        
        // Sort the list
        numbers.Sort();
        
        // Reverse the list
        numbers.Reverse();
        
        // Copy the list to an array
        int[] array = numbers.ToArray();
        
        // Length of the array
        int length = array.Length;

        // Iterate over the list
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
        // Remove all elements from the list
        numbers.Clear();
    }
}