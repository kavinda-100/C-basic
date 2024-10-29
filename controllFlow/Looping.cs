namespace Program.controllFlow;

public class Looping
{
    public Looping() { }
    
    public void Run()
    {
        Console.WriteLine("--------------Looping Practice:--------------------");
        
        Console.WriteLine("For loop:");
        ForLoop();
        Console.WriteLine("\n");
        
        Console.WriteLine("While loop:");
        WhileLoop();
        Console.WriteLine("\n");
        
        Console.WriteLine("Do while loop:");
        DoWhileLoop();
        Console.WriteLine("\n");
        
        Console.WriteLine("Break and continue:");
        BreakAndContinue();
        Console.WriteLine("\n");
        
        Console.WriteLine("Nested loops:");
        NestedLoops();
        Console.WriteLine("\n");
        
        Console.WriteLine("Looping through arrays:");
        LoopThroughArrays();
        Console.WriteLine("\n");
        
        Console.WriteLine("Foreach loop:");
        ForEachLoop();
        Console.WriteLine("\n");
    }
    
    // For loop
    private void ForLoop()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"For loop iteration: {i}");
        }
    }
    
    // While loop
    private void WhileLoop()
    {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine($"While loop iteration: {i}");
            i++;
        }
    }
    
    // Do while loop
    private void DoWhileLoop()
    {
        int i = 0;
        do
        {
            Console.WriteLine($"Do while loop iteration: {i}");
            i++;
        } while (i < 5);
    }
    
    // Break and continue
    private void BreakAndContinue()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            if (i % 2 == 0)
            {
                continue;
            }
            Console.WriteLine($"Break and continue: {i}");
        }
    }
    
    // Nested loops
    private void NestedLoops()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"Nested loops: {i} {j}");
            }
        }
    }
    
    // Looping through arrays
    private void LoopThroughArrays()
    {
        int[] numbers = {1, 2, 3, 4, 5};
        foreach (var number in numbers)
        {
            Console.WriteLine($"Looping through arrays: {number}");
        }
    }
    
    // foreach loop
    private void ForEachLoop()
    {
        string[] names = {"John", "Jane", "Doe"};
        foreach (var name in names)
        {
            Console.WriteLine($"Foreach loop: {name}");
        }
    }
}