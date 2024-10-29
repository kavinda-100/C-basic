namespace Program.ExceptionHandling;

public class ExceptionHandling
{
    public ExceptionHandling() { }
    
    // Run method
    public void Run()
    {
        Console.WriteLine("------------------------Exception Handling-----------------------------");
        
        Console.WriteLine("Handling exceptions:");
        HandleExceptions();
        Console.WriteLine("\n");
            
        Console.WriteLine("Throwing exceptions:");
        ThrowExceptions();
        Console.WriteLine("\n");
            
        Console.WriteLine("Finally block:");
        FinallyBlock();
        Console.WriteLine("\n");
    }
    
    // Handling exceptions
    private void HandleExceptions()
    {
        try
        {
            int[] numbers = {1, 2, 3};
            Console.WriteLine(numbers[3]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"IndexOutOfRangeException: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
        finally
        {
            Console.WriteLine("This block will always run");
        }
    }
    
    // Throwing exceptions
    private void ThrowExceptions()
    {
        try
        {
            throw new Exception("This is an exception");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
    }
    
    // Finally block
    private void FinallyBlock()
    {
        try
        {
            int[] numbers = {1, 2, 3};
            Console.WriteLine(numbers[2]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"IndexOutOfRangeException: {e.Message}");
        }
        finally
        {
            Console.WriteLine("This block will always run");
        }
    }
    
}