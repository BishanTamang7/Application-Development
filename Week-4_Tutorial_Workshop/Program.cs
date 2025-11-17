namespace Week_4_Tutorial_Workshop;

// Task 1

class Program
{
    static void Main(string[] args)
    {
        // Create two objects of Student class
        Student s1 = new Student();
        Student s2 = new Student();

        // Assign values to instance fields
        s1.Name = "Ram";
        s1.Age = 20;
        s1.Address = "Kathmandu";

        s2.Name = "Sita";
        s2.Age = 19;
        s2.Address = "Pokhara";

        // Display values for first object
        Console.WriteLine("Name: " + s1.Name);
        Console.WriteLine("Age: " + s1.Age);
        Console.WriteLine("Address: " + s1.Address);

        // Display values for second object
        Console.WriteLine("Name: " + s2.Name);
        Console.WriteLine("Age: " + s2.Age);
        Console.WriteLine("Address: " + s2.Address);

        // Display static field
        Console.WriteLine("\nSchool Name: " + Student.SchoolName);
    }
}


// Task 2

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // Create object of Calculator class
//         Calculator calc = new Calculator();
//
//         // Call PrintWelcome()
//         calc.PrintWelcome();
//
//         // Call Add method
//         int sum = calc.Add(10, 20);
//         Console.WriteLine("Addition: " + sum);
//
//         // Call Multiply method (with both values)
//         int product1 = calc.Multiply(5, 3);
//         Console.WriteLine("Multiplication (5 * 3): " + product1);
//
//         // Call Multiply method (using default value for num2)
//         int product2 = calc.Multiply(7);
//         Console.WriteLine("Multiplication (7 * default 1): " + product2);
//     }
// }


// Task 3

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         ParameterDemo demo = new ParameterDemo();
//
//         // REF example
//         int value = 5;
//         demo.Increase(ref value);
//         Console.WriteLine("Value after Increase: " + value);
//
//         // OUT example
//         string fullName;
//         demo.GetFullName(out fullName);
//         Console.WriteLine("Full Name: " + fullName);
//
//         // PARAMS example
//         int total = demo.SumAll(5, 10, 15, 20);
//         Console.WriteLine("Sum of all numbers: " + total);
//     }
// }


// Task 4

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // Object using default constructor
//         Player p1 = new Player();
//         Console.WriteLine("Player 1 Name: " + p1.playerName);
//         Console.WriteLine("Player 1 Level: " + p1.level);
//         Console.WriteLine("Player 1 Health: " + p1.health);
//
//         Console.WriteLine();
//
//         // Object using parameterized constructor
//         Player p2 = new Player("Arjun", 5, 100);
//         Console.WriteLine("Player 2 Name: " + p2.playerName);
//         Console.WriteLine("Player 2 Level: " + p2.level);
//         Console.WriteLine("Player 2 Health: " + p2.health);
//     }
// }