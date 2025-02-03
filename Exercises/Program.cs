using System.Numerics;

// Exercise1();
// Exercise2();
// Exercise3();
Excercise4();

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
  Console.WriteLine("--- Excercise 2 ---");
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
static void Excercise4()
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