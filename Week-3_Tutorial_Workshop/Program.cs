namespace Week_3_Tutorial_Workshop;


class Program
{
    static void Main(string[] args)
    {
        // Task 1
        Console.WriteLine("=======Task 1=======");
        Operators operators = new Operators();

        // Call all methods
        operators.Add(10, 5);
        operators.Subtract(10, 5);
        operators.Multiply(10, 5);
        operators.Divide(10, 5);
        operators.OddEvenFinder(7);
        
        
        // Task 2
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("=======Task 2=======");
        // Call the method to perform null checks
        NullOperations nullOps = new NullOperations();
        nullOps.PerformNullChecks();
        
        
        // Task 3
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("=======Task 3=======");
        // Get user input
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Determine age category using if – else if
        if (age < 13)
        {
            Console.WriteLine("You are a Child.");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("You are a Teenager.");
        }
        else
        {
            Console.WriteLine("You are an Adult.");
        }
        
        
        // Task 4
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("=======Task 4=======");
        // Get user input
        Console.Write("Enter a number (1–7): ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        // Use switch to determine the day of the week
        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid day number");
                break;
        }
        
        
        // Task 5
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("=======Task 5.1=======");
        Console.Write("Enter a number (N): ");
        int N = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine($"The sum from 1 to {N} is: {sum}");
        
        Console.WriteLine("");
        Console.WriteLine("=======Task 5.2=======");
        int num = 1;
        while (num <= 20)
        {
            // Stop the loop when number reaches 15
            if (num == 15)
            {
                Console.WriteLine("Reached 15 → Stopping the loop.");
                break;
            }

            // Skip multiples of 4
            if (num % 4 == 0)
            {
                num++;
                continue;
            }

            Console.Write(num + " ");
            num++;
        }
        
        Console.WriteLine("");
        Console.WriteLine("=======Task 5.3=======");
        int[] numbers = { 5, 10, 15, 20, 25 };
        int total = 0;

        foreach (int item in numbers)
        {
            total += item;
        }

        Console.WriteLine("Array elements: " + string.Join(", ", numbers));
        Console.WriteLine("Sum of all elements: " + total);
        
        
        // Task 6
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("=======Task 6.1=======");
        try
        {
            // Get user input
            Console.Write("Enter a number: ");
            string? userInput = Console.ReadLine();
            
            // Convert input to integer
            int number = Convert.ToInt32(userInput);
            
            Console.WriteLine($"The entered number is: {number}");
        }
        catch (FormatException)
        {
            // Handle invalid input
            Console.WriteLine("Invalid number format");
        }
        finally
        {
            // Always execute
            Console.WriteLine("Program Executed");
        }
        
        Console.WriteLine("");
        Console.WriteLine("=======Task 6.2=======");
        try
        {
            // Get password input
            Console.Write("Enter a password: ");
            string? password = Console.ReadLine();
            
            // Check if password is null or empty
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("Password cannot be empty.");
            }
            
            // Check if password length is less than 6
            if (password.Length < 6)
            {
                // Throw exception if password is too short
                throw new Exception("Password must be at least 6 characters.");
            }
            
            // If password satisfies the requirement
            Console.WriteLine("Password satisfied the requirement");
        }
        catch (Exception ex)
        {
            // Handle the thrown exception
            Console.WriteLine(ex.Message);
        }
    }
}