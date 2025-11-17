namespace Week_2_Tutorial_Workshop;


// Task 1:

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize variables
        string userName = "Bishan";
        int luckyNumber = 13;
        
        // Use string interpolation to display the message
        Console.WriteLine($"Hello {userName}!, your lucky number is {luckyNumber}.");
    }
}


// Task 2

// class Program
// {
//     static void Main(string[] args)
//     {
//         const double Pi = 3.14;
//         
//         //Printing Pi value without modifying
//         Console.WriteLine(Pi);
//         
//         //Trying to modify pi
//         Pi = Pi + 1;
//         
//         int r = 9; //Radius
//         Console.WriteLine("Area: "+(r*r)*Pi);
//         Console.WriteLine("Circumferences: "+2*Pi*r);
//     }
// }


// Task 3:

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Declare and initialize variables of different data types
//         byte byteVar = 255;
//         short shortVar = 32000;
//         int intVar = 100000;
//         long longVar = 1234567890L;
//         float floatVar = 3.14f;
//         double doubleVar = 2.71828;
//         decimal decimalVar = 123.456m;
//         char charVar = 'A';
//         bool boolVar = true;
//
//         // Type conversions
//         int number = 42;
//         // int to string
//         string numberAsString = number.ToString();
//         string piString = "3.14";
//         // string to double
//         double piValue = Convert.ToDouble(piString);
//         
//         Console.WriteLine($"byteVar: {byteVar}");
//         Console.WriteLine($"shortVar: {shortVar}");
//         Console.WriteLine($"intVar: {intVar}");
//         Console.WriteLine($"longVar: {longVar}");
//         Console.WriteLine($"floatVar: {floatVar}");
//         Console.WriteLine($"doubleVar: {doubleVar}");
//         Console.WriteLine($"decimalVar: {decimalVar}");
//         Console.WriteLine($"charVar: {charVar}");
//         Console.WriteLine($"boolVar: {boolVar}");
//         Console.WriteLine($"numberAsString: {numberAsString}");
//         Console.WriteLine($"piValue: {piValue}");
//     }
// }


// Task 4:

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create a single-dimensional integer array with 5 favorite numbers
//         int[] favoriteNumbers = { 7, 3, 9, 1, 5 };
//         
//         foreach (int num in favoriteNumbers)
//         {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine("\n");
//
//         // Sort the array in ascending order
//         Array.Sort(favoriteNumbers);
//         foreach (int num in favoriteNumbers)
//         {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine("\n");
//
//         // Reverse the sorted array
//         Array.Reverse(favoriteNumbers);
//         for (int i = 0; i < favoriteNumbers.Length; i++)
//         {
//             Console.Write(favoriteNumbers[i] + " ");
//         }
//         Console.WriteLine("\n");
//
//         // Find the position of a specific number using Array.IndexOf()
//         int searchNumber = 9;
//         int position = Array.IndexOf(favoriteNumbers, searchNumber);
//
//         if (position >= 0)
//         {
//             Console.WriteLine($"Number {searchNumber} found at index position {position}.");
//         }
//         else
//         {
//             Console.WriteLine($"Number {searchNumber} not found in the array.");
//         }
//     }
// }


// Task 5:

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create a DateTime variable for your birthdate
//         DateTime birthDate = new DateTime(2002, 3, 15);
//
//         // Create another DateTime variable for the current date and time
//         DateTime currentDate = DateTime.Now;
//
//         // Calculate age using TimeSpan
//         TimeSpan ageSpan = currentDate - birthDate;
//
//         // Convert total days to years
//         int ageInYears = (int)(ageSpan.TotalDays / 365.25);
//
//         // Add 10 days to your birthdate
//         DateTime birthDatePlus10Days = birthDate.AddDays(10);
//
//         
//         Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
//         Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
//         Console.WriteLine($"Age: {ageInYears} years");
//         Console.WriteLine($"Birthdate + 10 days: {birthDatePlus10Days.ToShortDateString()}");
//     }
// }


// Task 6:

// using System.Collections.Generic;
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Using List<string>
//         List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };
//
//         // Add a new fruit
//         fruits.Add("Orange");
//
//         // Remove one fruit
//         fruits.Remove("Banana");
//
//         // Print all fruits using foreach
//         Console.WriteLine("=== Favorite Fruits (List) ===");
//         foreach (string fruit in fruits)
//         {
//             Console.WriteLine(fruit);
//         }
//
//         Console.WriteLine();
//
//         // Using Dictionary<int, string>
//         Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
//         {
//             { 1, "Mango" },
//             { 2, "Apple" },
//             { 3, "Orange" }
//         };
//
//         // Add a new entry
//         fruitDictionary.Add(4, "Pineapple");
//
//         // Print all key-value pairs
//         Console.WriteLine("Fruit Dictionary (Key-Value Pairs)");
//         foreach (KeyValuePair<int, string> entry in fruitDictionary)
//         {
//             Console.WriteLine($"ID: {entry.Key}, Fruit: {entry.Value}");
//         }
//     }
// }