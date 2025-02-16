Console.WriteLine("---- Fun with Enums ----");

// Make an EmployeeTypeEnum variable.
// AskForBonus(EmployeeTypeEnum.Contractor);
// Type myEnumType = Enum.GetUnderlyingType(typeof(NotSequentialEmployeeTypeEnum));
// NotSequentialEmployeeTypeEnum employeeType = NotSequentialEmployeeTypeEnum.Contractor;
// Console.WriteLine($"{employeeType} = {(byte)employeeType}");

PrintValues(NotSequentialEmployeeTypeEnum.Contractor);

Console.ReadLine();

static void PrintValues(System.Enum e)
{
  Array enumData = Enum.GetValues(e.GetType());
  for (int i = 0; i < enumData.Length; i++)
  {
    Console.WriteLine("Name: {0}, Value: {0:D}",
    enumData.GetValue(i));
  }
}

// Enums as parameters.
static void AskForBonus(EmployeeTypeEnum employeeType)
{
  switch (employeeType)
  {
    case EmployeeTypeEnum.Manager:
      Console.WriteLine("How about stock options instead?");
      break;
    case EmployeeTypeEnum.Grunt:
      Console.WriteLine("You have got to be kidding...");
      break;
    case EmployeeTypeEnum.Contractor:
      Console.WriteLine("You already get enough cash...");
      break;
    case EmployeeTypeEnum.VicePresident:
      Console.WriteLine("VERY GOOD, Sir!");
      break;
  }
}

enum EmployeeTypeEnum
{
  Manager,       // 0
  Grunt,         // 1
  Contractor,    // 2
  VicePresident, // 3
}

enum CustomOrderEmployeeTypeEnum
{
  Manager = 100, // 100
  Grunt,         // 101
  Contractor,    // 102
  VicePresident, // 103
}

enum NotSequentialEmployeeTypeEnum
{
  Manager = 100,     // 100
  Grunt = 9,         // 9
  Contractor = 1,    // 1
  VicePresident = 0, // 0
}

// By default, the storage type used to hold the values of an enumeration is a System.Int32
// If you want to set the underlying storage value of EmployeeTypeEnum to be a byte rather than an int
// Numbers must be inside type's range
enum ByteEmployeeTypeEnum : byte
{
  Manager,       // 0
  Grunt,         // 1
  Contractor,    // 2
  VicePresident, // 3
}