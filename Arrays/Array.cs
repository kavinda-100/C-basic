namespace Program.Arrays;

public class Array
{
    public Array() { }
    
    public void Run()
    {
        Console.WriteLine("------------------------Arrays Practice-----------------------------");
        
        Console.WriteLine("Creating arrays:");
        CreateArrays();
        Console.WriteLine("\n");
            
        Console.WriteLine("Accessing arrays:");
        AccessArrays();
        Console.WriteLine("\n");
            
        Console.WriteLine("Modifying arrays:");
        ModifyArrays();
        Console.WriteLine("\n");
            
        Console.WriteLine("Iterating arrays:");
        IterateArrays();
        Console.WriteLine("\n");
            
        Console.WriteLine("Searching arrays:");
        SearchArrays();
        Console.WriteLine("\n");
        
        Console.WriteLine("Arrays manipulation:");
        ArraysManipulation();
        Console.WriteLine("\n");
        
        Console.WriteLine("Multidimensional arrays:");
        MultidimensionalArrays();
        Console.WriteLine("\n");
        
        Console.WriteLine("Looping through multidimensional arrays:");
        LoopMultidimensionalArrays();
        Console.WriteLine("\n");
    }
    
    // Creating arrays
    private void CreateArrays()
    {
        // Creating arrays
        int[] numbers = new int[3];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        
        int[] numbers2 = new int[] {1, 2, 3};
        
        int[] numbers3 = {1, 2, 3};
        
        Console.WriteLine("numbers: " + numbers[0] + ", " + numbers[1] + ", " + numbers[2]);
        Console.WriteLine("numbers2: " + numbers2[0] + ", " + numbers2[1] + ", " + numbers2[2]);
        Console.WriteLine("numbers3: " + numbers3[0] + ", " + numbers3[1] + ", " + numbers3[2]);
    }
    
    // Accessing arrays
    private void AccessArrays()
    {
        int[] numbers = {1, 2, 3};
        
        Console.WriteLine("Accessing arrays:");
        Console.WriteLine("First element: " + numbers[0]);
        Console.WriteLine("Last element: " + numbers[numbers.Length - 1]);
    }
    
    // Modifying arrays
    private void ModifyArrays()
    {
        int[] numbers = {1, 2, 3};
        
        numbers[0] = 10;
        numbers[numbers.Length - 1] = 30;
        
        Console.WriteLine("Modifying arrays:");
        Console.WriteLine("First element: " + numbers[0]);
        Console.WriteLine("Last element: " + numbers[numbers.Length - 1]);
    }
    
    // Iterating arrays
    private void IterateArrays()
    {
        int[] numbers = {1, 2, 3};
        
        Console.WriteLine("Iterating arrays:");
        Console.WriteLine("Using for loop:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + numbers[i]);
        }

        Console.WriteLine("Using foreach loop:");
        foreach (var number in numbers)
        {
            Console.WriteLine("Element: " + number);
        }
    }
    
    // Searching arrays
    private void SearchArrays()
    {
        int[] numbers = {1, 2, 3};
        
        int index = System.Array.IndexOf(numbers, 2);
        
        Console.WriteLine("Searching arrays:");
        Console.WriteLine("Index of 2: " + index);
    }
    
    // Sorting arrays
    private void ArraysManipulation()
    {
        int[] numbers = {3, 2, 1};
        
        // Sorting arrays
        System.Array.Sort(numbers);
        // Reversing arrays
        System.Array.Reverse(numbers);
        // Clearing arrays
        System.Array.Clear(numbers, 0, numbers.Length);
        
        Console.WriteLine("Sorting arrays:");
        Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
        Console.WriteLine("Reversing arrays:");
        Console.WriteLine("Reversed array: " + string.Join(", ", numbers));
        Console.WriteLine("Clearing arrays:");
        Console.WriteLine("Cleared array: " + string.Join(", ", numbers));
    }
    
    // Multidimensional arrays
    private void MultidimensionalArrays()
    {
        int[,] matrix = new int[2, 3];
        matrix[0, 0] = 1;
        matrix[0, 1] = 2;
        matrix[0, 2] = 3;
        matrix[1, 0] = 4;
        matrix[1, 1] = 5;
        matrix[1, 2] = 6;
        
        int[,] matrix2 = new int[,] {{1, 2, 3}, {4, 5, 6}};
        
        int[,] matrix3 = {{1, 2, 3}, {4, 5, 6}};
        
        Console.WriteLine("Multidimensional arrays:");
        Console.WriteLine("matrix: " + matrix[0, 0] + ", " + matrix[0, 1] + ", " + matrix[0, 2]);
        Console.WriteLine("matrix2: " + matrix2[0, 0] + ", " + matrix2[0, 1] + ", " + matrix2[0, 2]);
        Console.WriteLine("matrix3: " + matrix3[0, 0] + ", " + matrix3[0, 1] + ", " + matrix3[0, 2]);
    }
    
    // looping through multidimensional arrays
    private void LoopMultidimensionalArrays()
    {
        int[,] matrix = {{1, 2, 3}, {4, 5, 6}};
        
        Console.WriteLine("Looping through multidimensional arrays:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine("Element at index " + i + ", " + j + ": " + matrix[i, j]);
            }
        }
    }
    
}