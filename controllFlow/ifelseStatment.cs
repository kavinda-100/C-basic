namespace Program.controllFlow;

public class ifelseStatment
{
    public ifelseStatment(){}
    
    public void Run()
    {
        Console.WriteLine("--------------If else statement Practice:--------------------");
        
        Console.WriteLine("If else statement:");
        IfElseStatement();
        Console.WriteLine("\n");
    }
    
    private void IfElseStatement()
    {
        Random random = new Random();
        int number = random.Next(1, 10);
        
        if(number > 5)
        {
            Console.WriteLine("Number is greater than 5");
        }
        else
        {
            Console.WriteLine("Number is less than 5");
        }
    }
}