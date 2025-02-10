Console.WriteLine("--- Fun With Arrays ---");
// SimpleArrays();
// ArrayInitialization();
// DeclareImplicitArrays();
// ArrayOfObjects();
// RectangularMultidimensionalArray();
// JaggedMultidimensionalArray();
// PassAndReceiveArrays();
// SystemArrayFunctionality();
GetLastElement();

Console.ReadLine();

static void GetLastElement()
{
  string[] stringArray = { "Hello", "there", "my", "dear", "friend", "welcome" };
  foreach (string word in stringArray[2..])
  {
    Console.WriteLine($"word: {word}");
  }
  foreach (string word in stringArray[3..500])
  {
    Console.WriteLine($"word: {word}");
  }
  Console.WriteLine($"Last word: {stringArray[^1]}");
}

static void SystemArrayFunctionality()
{
  Console.WriteLine("=> Working with System.Array.");
  // Initialize items at startup.
  string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };
  // Print out names in declared order.
  Console.WriteLine("-> Here is the array:");
  for (int i = 0; i < gothicBands.Length; i++)
  {
    // Print a name.
    Console.Write(gothicBands[i] + ", ");
  }
  Console.WriteLine("\n");
  // Reverse them...
  Array.Reverse(gothicBands);
  Console.WriteLine("-> The reversed array");
  // ... and print them.
  for (int i = 0; i < gothicBands.Length; i++)
  {
    // Print a name.
    Console.Write(gothicBands[i] + ", ");
  }
  Console.WriteLine("\n");
  // Clear out all but the first member.
  Console.WriteLine("-> Cleared out all but one...");
  Array.Clear(gothicBands, 1, 2);
  for (int i = 0; i < gothicBands.Length; i++)
  {
    // Print a name.
    Console.Write(gothicBands[i] + ", ");
  }
  Console.WriteLine();
}

static void PassAndReceiveArrays()
{
  Console.WriteLine("-> Arrays as params and return values.");
  // Pass array as parameter.
  int[] ages = { 20, 22, 23, 0 };
  PrintArray(ages);
  // Get array as return value.
  string[] strs = PopulateStringArray();
  foreach (string s in strs)
  {
    Console.WriteLine(s);
  }
  Console.WriteLine();
}

static void PrintArray(int[] intArray)
{
  for (int i = 0; i < intArray.Length; i++)
  {
    Console.WriteLine($"{i} = {intArray[i]}");
  }
}

static string[] PopulateStringArray()
{
  string[] stringArray = new string[] { "hello", "everyone", "bye" };
  return stringArray;
}

static void JaggedMultidimensionalArray()
{
  Console.WriteLine("-> Jagged multidimensional array.");
  // A jagged MD array (i.e., an array of arrays).
  // Here we have an array of 5 different arrays.
  int[][] myJagArray = new int[5][];
  // Create the jagged array.
  for (int i = 0; i < myJagArray.Length; i++)
  {
    myJagArray[i] = new int[i + 7];
  }
  // Print each row (remember, each element is defaulted to zero!).
  for (int i = 0; i < 5; i++)
  {
    for (int j = 0; j < myJagArray[i].Length; j++)
    {
      Console.Write(myJagArray[i][j] + " ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

static void RectangularMultidimensionalArray()
{
  Console.WriteLine("-> Rectangular multidimensional array.");
  int[,] myMatrix = new int[3, 4];
  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 4; j++)
    {
      myMatrix[i, j] = i * j;
    }
  }

  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 4; j++)
    {
      Console.Write($"{myMatrix[i, j]}\t");
    }
    Console.WriteLine();
  }
}

static void ArrayOfObjects()
{
  object[] objectArray = new object[4];

  objectArray[0] = 1;
  objectArray[1] = true;
  objectArray[2] = "Hello";
  objectArray[3] = new DateTime(1999, 2, 20);

  foreach (object obj in objectArray)
  {
    Console.Write($"Type: {obj.ToString()}, Value: {obj.GetType()}");
  }
  Console.WriteLine();
}

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

  // d -> Mixed Types (Error)
  // var d = new[] {1, null, "Hello"};
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