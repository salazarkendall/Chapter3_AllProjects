using System.Numerics;

Exercise1();
Exercise2();
Exercise3();

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