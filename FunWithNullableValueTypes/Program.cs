LocalNullableVariables();
LocalNullableVariablesUsingNullable();

DataBaseReader dbReader = new();

int myData = dbReader.GetNumericFromDB() ?? 100; // assign 100 to myData if dbReader.GetNumericFromDB() returns null
Console.WriteLine($"myData -> {myData}");

int? myNullableInt = null;
myNullableInt ??= 14;
myNullableInt ??= 22;
Console.WriteLine($"myNullableInt -> {myNullableInt}");


// Get int from database
var possibleInt = dbReader.GetNumericFromDB();
if (possibleInt.HasValue)
{
  Console.WriteLine($"possibleInt -> {possibleInt.Value}");
}
else
{
  Console.WriteLine("possibleInt has no value yet");
}
// Get bool from database
var possibleBool = dbReader.GetBoolFromDB();
if (possibleBool != null)
{
  Console.WriteLine($"possibleBool -> {possibleBool.Value}");
}
else
{
  Console.WriteLine("possibleBool has no value yet");
}

// TesterMethod(); 

static void TesterMethod(string?[] args)
{
  // We should check for null before accessing the array data!
  Console.WriteLine($"You sent me {args?.Length ?? 0} arguments.");
}

static void LocalNullableVariables()
{
  bool? nullableBool = null;
  double? nullableDouble = null;
  int? nullableInt = 10;
  char? nullableChart = 'a';
  int?[] nullableArray = new int?[10];
  Console.WriteLine($"{nullableBool}, {nullableDouble}, {nullableInt}, {nullableChart}, {nullableArray}");
  if (nullableChart.HasValue) Console.WriteLine($"nullableChart -> {nullableChart}");
}

static void LocalNullableVariablesUsingNullable()
{
  Nullable<bool> nullableBool = null;
  Nullable<double> nullableDouble = null;
  Nullable<int> nullableInt = 10;
  Nullable<char> nullableChart = 'a';
  Nullable<int>[] nullableArray = new int?[10];
  Console.WriteLine($"{nullableBool}, {nullableDouble}, {nullableInt}, {nullableChart}, {nullableArray}");
  if (nullableChart.HasValue) Console.WriteLine($"nullableChart -> {nullableChart}");
}

class DataBaseReader
{
  public int? numericValue;
  public bool? boolValue = true;
  public int? GetNumericFromDB() { return numericValue; }
  public bool? GetBoolFromDB() { return boolValue; }
}