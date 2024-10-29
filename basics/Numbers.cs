namespace Program;

public class Numbers
{
    public Numbers(){ }

    public void Run()
    {
        Console.WriteLine("--------------Numbers Practice:--------------------");
        
        Console.WriteLine("type conversion");
        ConvertNumbers();
        Console.WriteLine("\n");
    }
    
    //type conversion
    private void ConvertNumbers()
    {
        int numbers = 1;
        float floatNumber = 3.14f;
        double doubleNumber = 3.14159265359;
        
        Console.WriteLine("Converting numbers:");
        Console.WriteLine("Float to int: " + (int)floatNumber);
        Console.WriteLine("Double to int: " + (int)doubleNumber);
        Console.WriteLine("Int to float: " + (float)numbers);
        Console.WriteLine("Int to double: " + (double)numbers);
        
        // we can also covert like this
        // Console.WriteLine("Int to float: " + Convert.ToSingle(numbers));
        // Console.WriteLine("Int to double: " + Convert.ToDouble(numbers));
        // Console.WriteLine("Float to int: " + Convert.ToInt32(floatNumber));
        // Console.WriteLine("Double to int: " + Convert.ToInt32(doubleNumber));
    }
}