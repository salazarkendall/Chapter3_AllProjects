Console.WriteLine("**** Fun with Basic Data Types ****");
DefaultDeclarations();
LocalVarDeclarations();
NewingDataTypes();
ObjectFunctionality();

static void ObjectFunctionality()
{
    Console.WriteLine("-> System.Object functionality");

    int i = default;
    int j = 0;
    Console.WriteLine("i.ToString() = {0}", i.ToString());
    Console.WriteLine("i.Equals(j) = {0}", i.Equals(j));
    Console.WriteLine("i.GetHashCode() = {0}", i.GetHashCode());
    Console.WriteLine("i.GetType() = {0}", i.GetType());
}

static void NewingDataTypes()
{
    // Use default instead of new bool() for better readability and efficiency,
    // as 'default' avoids an unnecessary constructor call.
    Console.WriteLine("-> Using 'new' to create Data Types");
    bool b = new bool(); // set to false.
    int i = new int(); // set to 0.
    double d = new double(); // set to 0.
    DateTime dt = new DateTime(); // set to 1/1/0001 12:00:00 AM

    string example = "Test";
    example.Equals(dt);

    Console.WriteLine("Default values (using 'new' keyword)");
    Console.WriteLine("bool: {0}", b);
    Console.WriteLine("int: {0}", i);
    Console.WriteLine("double: {0}", d);

    // You can achieve the same result using the 'new()' functionality in C# 9.0
    // Just like this:
    bool b2 = new();
    int i2 = new();
    double d2 = new();
    DateTime dt2 = new();

    Console.WriteLine("Default values (using 'new()' functionality)");
    Console.WriteLine("bool: {0}", b2);
    Console.WriteLine("int: {0}", i2);
    Console.WriteLine("double: {0}", d2);
    Console.WriteLine("DateTime: {0}", dt2);
}

static void DefaultDeclarations()
{
    Console.WriteLine("-> Dafult Declarations");
    int myInt = default;
    Console.WriteLine(myInt);
}

static void LocalVarDeclarations()
{
    Console.WriteLine("-> Data Declarations");
    Console.Beep();

    // Local variables are declared and initialized as follows:
    // dataType varName = initValue;
    int myInt = 0;

    // You can also declare and assign on two lines:
    string myString;
    myString = "Kendall";

    // Declare 3 bools on a single line:
    bool b1 = false, b2 = true, b3 = b1;

    // Use System.Boolean data type to declare a bool:
    System.Boolean b4 = true;

    Console.WriteLine("Your data: {0} {1} {2} {3} {4} {5}", myInt, myString, b1, b2, b3, b4);
    Console.ReadLine();
    Console.Beep();
    Console.WriteLine("**** End of Code ****");
}