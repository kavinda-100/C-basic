namespace Program.Date_and_time;

public class DateAndTime
{
    public static void Run()
    {
        var date = new DateTime(2021, 12, 31);
        var time = new DateTime(2021, 12, 31, 23, 59, 59);
        
        Console.WriteLine($"data = {date.ToString("yy-MMM-dd ddd")}");
        Console.WriteLine($"time = {time}");
        
        var dt = DateTime.Now;
        Console.WriteLine($"current date and time = {dt}");
        Console.WriteLine($"current day = {dt.Day}");
        Console.WriteLine($"current month = {dt.Month}");
        Console.WriteLine($"current year = {dt.Year}");
        Console.WriteLine($"current hour = {dt.Hour}");
        Console.WriteLine($"current minute = {dt.Minute}");
        Console.WriteLine($"current second = {dt.Second}");
        
    }
}