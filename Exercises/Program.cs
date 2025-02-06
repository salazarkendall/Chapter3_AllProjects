using System.Numerics;

// Exercise1();
// Exercise2();
// Exercise3();
// Exercise4();
// Exercise5();
// Exercise6();
// Exercise7();
Exercise8();

// Exercise 1:
// Ask the user to enter a very large number (more than 30 digits).
// Convert that number into a BigInteger.
// Determine if the number is even or a power of two.
// Display the results on the console.
static void Exercise1()
{
  Console.WriteLine("--- Exercise 1 ---");
  Console.WriteLine("Please enter a very large number (more than 30 digits):");
  var input = Console.ReadLine();
  if (input?.Length > 30 && BigInteger.TryParse(input, out BigInteger result))
  {
    Console.WriteLine("-> BIGINT: {0}", result);
    Console.WriteLine("-> Is this number even? {0}", result.IsEven);
    Console.WriteLine("-> Is this number power of two? {0}", result.IsPowerOfTwo);
  }
  else
  {
    Console.WriteLine("-> Not a valid number");
  }
  Console.ReadLine();
}

// Exercise 2:
// Define two large numbers as BigInteger.
// Perform and display the results of the following operations between them:
// Addition, subtraction, multiplication, division, and modulus.
static void Exercise2()
{
  Console.WriteLine("--- Exercise 2 ---");
  string fakeNumber = "999999999999999999999999999999";
  _ = BigInteger.TryParse(fakeNumber, out BigInteger bigInt1);
  _ = BigInteger.TryParse(fakeNumber, out BigInteger bigInt2);
  Console.WriteLine("The fake number is: {0}", fakeNumber);
  Console.WriteLine("-> Addition:       {0}", BigInteger.Add(bigInt1, bigInt2));
  Console.WriteLine("-> Subtraction:    {0}", BigInteger.Subtract(bigInt1, bigInt2));
  Console.WriteLine("-> Multiplication: {0}", BigInteger.Multiply(bigInt1, bigInt2));
  Console.WriteLine("-> Division:       {0}", BigInteger.Divide(bigInt1, bigInt2));
  Console.ReadLine();
}

// Exercise 3
// Create a program that calculates the factorial of a large number (e.g., 100!) using BigInteger.
static void Exercise3()
{
  Console.WriteLine("--- Exercise 3 ---");
  Console.WriteLine("Please enter a number (we are going to make a factorial out of it!)");
  if (int.TryParse(Console.ReadLine(), out int baseNumber))
  {
    BigInteger bigNumber = BigInteger.One;
    for (int i = 1; i <= baseNumber; i++)
    {
      bigNumber = BigInteger.Multiply(bigNumber, i);
    }
    Console.WriteLine("-> {0}! == {1}", baseNumber, bigNumber);
  }
  else
  {
    Console.WriteLine("-> Not a valid number");
  }
}

// Exercise 4:
// Get the current date and time.
// Extract only the date using DateOnly and only the time using TimeOnly.
// Display both values on the console.
static void Exercise4()
{
  Console.WriteLine("--- Exercise 4 ---");
  DateTime dt = DateTime.Now;
  DateOnly onlyDate = new(dt.Year, dt.Month, dt.Day);
  TimeOnly onlyTime = new(dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
  Console.WriteLine("-> Original Date: {0}", dt);
  Console.WriteLine("-> Date Only: {0}", onlyDate);
  Console.WriteLine("-> Time Only: {0}", onlyTime);

  // PRO TIP:
  // Use DateOnly.FromDateTime and TimeOnly.FromDateTime constructors instead:
  DateOnly myDateOnly = DateOnly.FromDateTime(dt);
  TimeOnly myTimeOnly = TimeOnly.FromDateTime(dt);
  Console.WriteLine("-> PRO TIP: use methods to simplify code:");
  Console.WriteLine("   -> DateOnly.FromDateTime(dt): {0}", myDateOnly);
  Console.WriteLine("   -> TimeOnly.FromDateTime(dt): {0}", myTimeOnly);
}

// Exercise 5:
// Ask the user to enter a birthdate.
// Use DateOnly to calculate how many days have passed since that date until today.
static void Exercise5()
{
  Console.WriteLine("--- Exercise 5 ---");
  Console.WriteLine("-> Please enter your birthday (YYYY-MM-DD)");
  if (DateOnly.TryParse(Console.ReadLine(), out DateOnly bday))
  {
    DateOnly today = DateOnly.FromDateTime(DateTime.Today);
    Console.WriteLine($"Today is {today}, your birthday is {bday}, {today.DayNumber - bday.DayNumber} days have passed since that date until today");
  }
  else
  {
    Console.WriteLine("Invalid date format");
  }
}

// Exercise 6:
// Create a program that receives two times entered by the user.
// Use TimeOnly to calculate the difference between them.
static void Exercise6()
{
  Console.WriteLine("--- Exercise 6 ---");
  Console.WriteLine("   -> Hit the keyboard now:");
  Console.ReadKey();
  TimeOnly firstTimeStamp = TimeOnly.FromDateTime(DateTime.Now);
  Console.WriteLine("   -> Now hit the keyboard again:");
  Console.ReadKey();
  TimeOnly secondTimeStamp = TimeOnly.FromDateTime(DateTime.Now);
  Console.WriteLine($"   -> Difference between keyboard hits: {secondTimeStamp - firstTimeStamp}");
}

// Exercise 7:
// Ask the user to enter a number in text format.
// Use TryParse to attempt converting it to an int and a double.
// If the conversion fails, display a message indicating that the value is invalid.
static void Exercise7()
{
  Console.WriteLine("--- Exercise 7 ---");
  Console.WriteLine("-> Please enter a valid number");
  string? input = Console.ReadLine();
  if (int.TryParse(input, out int inputInt))
  {
    Console.WriteLine($"   -> Input int value: {inputInt}");
  }
  else if (double.TryParse(input, out double inputDouble))
  {
    Console.WriteLine($"   -> Input double value: {inputDouble}");
  }
  else
  {
    Console.WriteLine("-> Not a valid number");
  }
}

// Exercise 8:
// Create a program that receives a text input and tries to convert it into bool, int, double, and DateTime, displaying whether the conversion was successful or not for each type.
static void Exercise8()
{
  Console.WriteLine("--- Exercise 8 ---");
  Console.WriteLine("-> Enter a value:");

  string? input = Console.ReadLine();
  if (bool.TryParse(input, out bool boolConversion))
  {
    Console.WriteLine($"   -> Successful boolean conversion: {boolConversion}");
  }
  else
  {
    Console.WriteLine("   -> Unsuccessful boolean conversion");
  }

  if (int.TryParse(input, out int intResult))
  {
    Console.WriteLine($"   -> Successful int conversion: {intResult}");
  }
  else
  {
    Console.WriteLine("   -> Unsuccessful int conversion");
  }

  if (double.TryParse(input, out double doubleConversion))
  {
    Console.WriteLine($"   -> Successful double conversion: {doubleConversion}");
  }
  else
  {
    Console.WriteLine("   -> Unsuccessful double conversion");
  }

  if (DateTime.TryParse(input, out DateTime dateTimeConversion))
  {
    Console.WriteLine($"   -> Successful DateTime conversion: {dateTimeConversion}");
  }
  else
  {
    Console.WriteLine("   -> Unsuccessful DateTime conversion");
  }

}

// Exercise 9:
// Ask the user to enter a character.
// Verify if it is a letter, a number, a whitespace, or a punctuation mark.

// Exercise 10:
// Write a program that iterates through a text string and counts how many uppercase letters, lowercase letters, and numbers it contains.

// Exercise 11:
// Declare variables of different types (int, double, bool, char, string, DateTime).
// Print their default values without assigning any initial value.

// Exercise 12:
// Use var to declare different variables and check what data type the compiler infers for each case.

// Exercise 13:
// Declare a generic object (object) and assign different data types (int, string, double).
// Print its actual type using .GetType().

// Exercise 14:
// Compare two different objects using .Equals() and display the result.
// Retrieve their hash values using .GetHashCode() and analyze them.