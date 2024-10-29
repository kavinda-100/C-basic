namespace Program.Functions;

public class Function
{
    public Function(){}
    
    public void Run()
    {
        Console.WriteLine("--------------Functions Practice:--------------------");
        
        Console.WriteLine("Function with return value:");
        int result = Add(1, 2);
        Console.WriteLine($"Addition of 1 and 2 is: {result}");
        Console.WriteLine("\n");
        
        Console.WriteLine("Function with multiple return values:");
        int sum, product;
        SumAndProduct(2, 3, out sum, out product);
        Console.WriteLine($"Sum of 2 and 3 is: {sum}");
        Console.WriteLine($"Product of 2 and 3 is: {product}");
        Console.WriteLine("\n");
        
        Console.WriteLine("Function with default parameter:");
        int result2 = Add2(1);
        Console.WriteLine($"Addition of 1 and default value is: {result2}");
        Console.WriteLine("\n");
        
        Console.WriteLine("Function with named parameter:");
        int result3 = Add3(b: 2, a: 1);
        Console.WriteLine($"Addition of 1 and 2 is: {result3}");
        Console.WriteLine("\n");
        
        Console.WriteLine("Function with params parameter:");
        int result4 = Add4(1, 2, 3, 4, 5);
        Console.WriteLine($"Addition of 1, 2, 3, 4, 5 is: {result4}");
        Console.WriteLine("\n");
    }
    
    // Function with return value
    private int Add(int a, int b)
    {
        return a + b;
    }
    
    // Function with multiple return values
    private void SumAndProduct(int a, int b, out int sum, out int product)
    {
        sum = a + b;
        product = a * b;
    }
    
    // Function with default parameter
    private int Add2(int a, int b = 10)
    {
        return a + b;
    }
    
    // Function with named parameter
    private int Add3(int a, int b)
    {
        return a + b;
    }
    
    // Function with `params` parameter
    private int Add4(params int[] numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}
