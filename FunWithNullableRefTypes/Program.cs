string? nullableString = null;
TestClass? myNullableClass = null;

TestClass myNonNullableClass = null; // Converting null literal or possible null value to non-nullable type. (CS8600)

#nullable disable
TestClass anotherNullableClass = null;
//Warning CS8632 The annotation for nullable reference types
//should only be used in code within a '#nullable' annotations
TestClass? badDefinition = null;
//Warning CS8632 The annotation for nullable reference types
//should only be used in code within a '#nullable' annotations
string? anotherNullableString = null;
#nullable restore

string? msg = null;
EnterLogData(msg);
//Warning CS8604 Possible null reference argument for parameter 'message' in
//      'void EnterLogData(string message, string owner = "Programmer")'.

static void EnterLogData(string message, string owner = "Programmer")
{
  ArgumentNullException.ThrowIfNull(message);
  Console.WriteLine("Error: {0}", message);
  Console.WriteLine("Owner of Error: {0}", owner);
}
public class TestClass
{
  public string Name { get; set; }
  public int Age { get; set; }
}