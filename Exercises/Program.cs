using System.Numerics;

Exercise1();

// Exercise 1:
// Ask the user to enter a very large number (more than 30 digits).
// Convert that number into a BigInteger.
// Determine if the number is even or a power of two.
// Display the results on the console.
static void Exercise1()
{
  Console.WriteLine("Please enter a very large number (more than 30 digits):");
  if (BigInteger.TryParse(Console.ReadLine(), out BigInteger result))
  {
    Console.WriteLine("BIGINT: {0}", result);
    Console.WriteLine("Is this number even? {0}", result.IsEven);
    Console.WriteLine("Is this number power of two? {0}", result.IsPowerOfTwo);
  }
  else
  {
    Console.WriteLine("Not a valid number");
  }
}