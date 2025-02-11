Console.WriteLine("***** Fun with Methods *****\n");

// Pass two variables in by value.
int x = 9, y = 10;
Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
Console.WriteLine("Answer is: {0}", Add(x, y));
Console.WriteLine("After call: X: {0}, Y: {1}", x, y);

AddOut(3, 4, out int ans);
Console.WriteLine($"AddOut(3, 4) -> {ans}");

FillTheseValues(out int a, out string b, out bool c);
Console.WriteLine(@$"
  -> A: {a}
  -> B: {b}
  -> C: {c}
");

string str1 = "Flip";
string str2 = "Flop";
Console.WriteLine("Before: {0}, {1} ", str1, str2);
SwapStrings(ref str1, ref str2);
Console.WriteLine("After: {0}, {1} ", str1, str2);

CalculateAverage(1, 2, 3, 4, 5, 6);
Add(x: 100, y: 200); // Named arguments

Console.ReadLine();

// Return average of "some number" of doubles.
static double CalculateAverage(params double[] values)
{
  Console.WriteLine("You sent me {0} doubles.", values.Length);
  double sum = 0;
  if (values.Length == 0) return sum;
  Console.WriteLine(values.GetType().Name);
  for (int i = 0; i < values.Length; i++)
  {
    sum += values[i];
  }
  return sum / values.Length;
}

static int AddReadOnly(in int x, in int y)
{
  // x = 1000; // Cannot modify read-only variable
  return x + y;
}

// Reference parameters.
static void SwapStrings(ref string s1, ref string s2)
{
  string tempStr = s1;
  s1 = s2;
  s2 = tempStr;
}

static void FillTheseValues(out int a, out string b, out bool c)
{
  a = 9;
  b = "Enjoy your string.";
  c = true;
}

static int Add(int x, int y)
{
  int ans = x + y;
  // Caller will not see these changes
  // as you are modifying a copy of the
  // original data.
  x = 8000;
  y = 10000;
  return ans;
}
static void AddOut(int x, int y, out int ans)
{
  ans = x + y;
}