namespace Program.controllFlow;

public class SwitchStatment
{
    public SwitchStatment(){}
    
    public void Run()
    {
        Console.WriteLine("--------------Switch statement Practice:--------------------");
        
        Console.WriteLine("Switch statement:");
        SwitchStatement();
        Console.WriteLine("\n");
    }
    
    private void SwitchStatement()
    {
        Random random = new Random();
        int number = random.Next(1, 10);
        
        switch(number)
        {
            case 1:
                Console.WriteLine("Number is 1");
                break;
            case 2:
                Console.WriteLine("Number is 2");
                break;
            case 3:
                Console.WriteLine("Number is 3");
                break;
            case 4:
                Console.WriteLine("Number is 4");
                break;
            case 5:
                Console.WriteLine("Number is 5");
                break;
            default:
                Console.WriteLine("Number is greater than 5");
                break;
        }
    }
}