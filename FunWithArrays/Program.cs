Console.WriteLine("--- Fun With Arrays ---");
// SimpleArrays();
// ArrayInitialization();
DeclareImplicitArrays();
Console.ReadLine();

static void DeclareImplicitArrays()
{
  // a is really int[]
  var a = new[] { 1, 10, 100, 1000 };
  Console.WriteLine($"a is a: {a}");

  // b is really double[]
  var b = new[] { 1, 1.1, 1.11, 1.111 };
  Console.WriteLine($"b is a: {b}");

  // c is really string[]
  var c = new[] { "hello", null, "there" };
  Console.WriteLine($"c is a: {c}");
}

static void ArrayInitialization()
{
  // Initialization using "new" keyword
  string[] stringArray = new string[] { "one", "two", "three" };
  Console.WriteLine($"stringArray Length -> ${stringArray.Length}");

  // Initialization with "new" keyword and size
  int[] intArray = new int[3] { 1, 2, 3 };

  // Initialization without using "new" keyword
  bool[] boolArray = { false, false, true };
  Console.WriteLine($"boolArray Length -> ${boolArray.Length}");
}

static void SimpleArrays()
{
  Console.WriteLine("-> Simple Array Creation");
  // Create and fill an array of 3 integers
  int[] ints = new int[3];
  ints[0] = 100;
  ints[1] = 200;
  ints[2] = 300;

  // Now print each value
  foreach (int i in ints)
  {
    Console.WriteLine(i);
  }
  // Create a 100 item string array, indexed 0 - 99
  string[] booksOnDotnet = new string[100];
  Console.WriteLine();
}