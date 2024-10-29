namespace Program;

public class StringsPractice
{
    public StringsPractice() { }
    
    // Run method
    public void Run()
    {
        Console.WriteLine("------------------------Strings Practice-----------------------------");
        
        Console.WriteLine("Concatenating strings:");
        ConcatenateStrings();
        Console.WriteLine("\n");
            
        Console.WriteLine("Comparing strings:");
        CompareStrings();
        Console.WriteLine("\n");
            
        Console.WriteLine("Manipulating strings:");
        ManipulateStrings();
        Console.WriteLine("\n");
            
        Console.WriteLine("Formatting strings:");
        FormatStrings();
        Console.WriteLine("\n");
            
        Console.WriteLine("String searching:");
        SearchStrings();
        Console.WriteLine("\n");
    }
    
    // Concatenating strings
    private void ConcatenateStrings()
    {
        var name = "John";
        var lastName = "Doe";
        
        string fullName = name + " " + lastName;
        string fullName2 = string.Concat(name, " ", lastName);
        string fullName3 = $"{name} {lastName}";
        Console.WriteLine($"fullName: {fullName}");
        Console.WriteLine($"fullName2 using `Concat method`: {fullName2}");
        Console.WriteLine($"fullName3 using string interpolation: {fullName3}");
    }
    
    // String comparison
    private void CompareStrings()
    {
        string name = "John";
        string name2 = "John";
        string name3 = "john";
        
        bool areEqual = name == name2;
        bool areEqual2 = name.Equals(name2);
        bool areEqual3 = name.Equals(name3, StringComparison.OrdinalIgnoreCase);
        
        Console.WriteLine($"areEqual: {areEqual}");
        Console.WriteLine($"areEqual2 using `Equals method`: {areEqual2}");
        Console.WriteLine($"areEqual3 using `Equals method` with `StringComparison.OrdinalIgnoreCase`: {areEqual3}");
    }
    
    // String manipulation
    private void ManipulateStrings()
    {
        string name = "John Doe";
        
        string upperCase = name.ToUpper();
        string lowerCase = name.ToLower();
        string trimmed = name.Trim(); // Removes leading and trailing white spaces
        // string trimmed = name.TrimEnd(); // Removes trailing white spaces
        // string trimmed = name.TrimStart(); // Removes leading white spaces
        string replaced = name.Replace("John", "Jane");
        // Splitting the string by space to get an array of strings
        string[] split = name.Split(" ");
        
        Console.WriteLine($"{name} to upperCase: {upperCase}");
        Console.WriteLine($"{name} to lowerCase: {lowerCase}");
        Console.WriteLine($"{name} to trimmed: {trimmed}");
        Console.WriteLine($"{name} to replaced: {replaced}");
        // Joining the array of strings back to a single string
        Console.WriteLine($"{name} to split: {string.Join(", ", split)}");
    }
    
    // String formatting
    private void FormatStrings()
    {
        string name = "John";
        int age = 30;
        
        string formatted = string.Format("Name: {0}, Age: {1}", name, age);
        string formatted2 = $"Name: {name}, Age: {age}";
        
        Console.WriteLine($"formatted: {formatted}");
        Console.WriteLine($"formatted2 using string interpolation: {formatted2}");
    }
    
    // String searching
    private void SearchStrings()
    {
        string name = "John Doe";
        
        bool startsWith = name.StartsWith("John");
        bool endsWith = name.EndsWith("Doe");
        bool contains = name.Contains("Doe");
        int indexOf = name.IndexOf("Doe");
        
        Console.WriteLine($"{name} starts with John: {startsWith}");
        Console.WriteLine($"{name} ends with Doe: {endsWith}");
        Console.WriteLine($"{name} contains Doe: {contains}");
        Console.WriteLine($"{name} index of Doe is: {indexOf}");
    }
    
}