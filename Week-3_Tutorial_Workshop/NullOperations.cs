namespace Week_3_Tutorial_Workshop;

public class NullOperations
{
    // Method to demonstrate null checking techniques
    public void PerformNullChecks()
    {
        // Declare username and assign null
        string username = null;

        // Ternary Operator: Check if null
        Console.WriteLine(username == null ? "Username is not available" : username);

        // Null-Coalescing Operator: Check if null
        Console.WriteLine(username ?? "Username is not available");

        // Null-Coalescing Assignment Operator: Assign default if null
        username ??= "DefaultUser";

        // Print updated username
        Console.WriteLine(username);
    }
}