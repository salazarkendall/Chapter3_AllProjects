using System.Numerics;

Console.WriteLine("**** Fun with Basic Data Types ****");

//DefaultDeclarations();
//LocalVarDeclarations();
//NewingDataTypes();
//ObjectFunctionality();
//DataTypeFunctionality();
//CharFunctionality();
//ParseFromStrings();
// ParseFromStringWithTryParse();
// UseDateAndTime();
// UseDateOnlyAndTimeOnly();
// UseBigInteger();
// DigitSeparator();
// BasicStringFunctionality();
StringEquality();

static void StringEquality()
{
    Console.WriteLine("-> String Equality");
    string string1 = "Hello there!";
    string string2 = "Kendall Salazar";
    Console.WriteLine($"string1 -> {string1}");
    Console.WriteLine($"string2 -> {string2}");

    // Equality test:
    Console.WriteLine($"string1 == string2 -> {string1 == string2}");
    Console.WriteLine($"string1.Equals(string2) -> {string1.Equals(string2)}");
    Console.WriteLine($"string2.Equals(string1) -> {string2.Equals(string1)}");

    string test1 = "café";
    string test2 = "cafe";

    Console.WriteLine($"café == cafe ? {test1 == test2}");
    Console.WriteLine($"café == cafe ? {test1.Equals(test2)}");
    Console.WriteLine($"café == cafe ? {test1.CompareTo(test2)}");
    Console.WriteLine($"café == cafe ? {string.Compare(test1, test2, StringComparison.InvariantCultureIgnoreCase)}");


    Console.ReadLine();
}

static void StringConcatenation()
{
    Console.WriteLine("-> String concatenation:");
    string s1 = "Programming the ";
    string s2 = "PsychoDrill (PTP)";
    string s3 = String.Concat(s1, s2);
    string s4 = s1 + s2; //Internally, the compiler make use of String.Concat();
    Console.WriteLine(s3);
    Console.WriteLine();
}

static void BasicStringFunctionality()
{
    Console.WriteLine("-> Basic String functionality:");
    string firstName = "Freddy";
    Console.WriteLine("Value of firstName: {0}", firstName);
    Console.WriteLine("firstName has {0} characters.", firstName.Length);
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
    Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
    Console.WriteLine("firstName contains the letter y?: {0}",
    firstName.Contains("y"));
    Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
    Console.WriteLine();
}

static void DigitSeparator()
{
    Console.WriteLine("-> Digit Separator");
    int myInteger = 1_2_3;
    double myDouble = 12.34_56_78;
    Console.WriteLine($@"
    -> Integer: {myInteger}
    -> Double: {myDouble}
    ");
}


// Exercises material end here

static void UseBigInteger()
{
    Console.WriteLine("-> Use BigInteger:");
    BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999999");
    Console.WriteLine("Value of biggy is {0}", biggy);
    Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
    Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
    BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("8888888888888888888888888888888888888888888"));
    Console.WriteLine("Value of reallyBig is {0}", reallyBig);
}

static void UseDateOnlyAndTimeOnly()
{
    // DateOnly and TimeOnly structs aligns with the SQL Server Date type and Time tipe respectively
    Console.WriteLine("-> Using DateOnly and TimeOnly");
    DateOnly myDateOnly = new(1999, 02, 20);
    Console.WriteLine("My BD was on {0}", myDateOnly);

    TimeOnly myTimeOnly = new(0, 45, 0, 0);
    Console.WriteLine("My TimeOnly variable contains: {0}", myTimeOnly);
}

static void UseDateAndTime()
{
    Console.WriteLine("-> Using DateTime and TimeSpan");
    DateTime dt = new(1999, 02, 20);
    Console.WriteLine("I was born in {0}, it was a {1}", dt, dt.DayOfWeek);

    int additionalMonths = 2;
    dt = dt.AddMonths(additionalMonths);
    Console.WriteLine("{0} months later was {1}", additionalMonths, dt);
    Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

    TimeSpan ts = new(4, 30, 0);
    Console.WriteLine(ts);
    Console.WriteLine("Current timespan: {0}, 15 minutes before was {1}", ts, ts.Subtract(new TimeSpan(0, 15, 0)));
}

static void ParseFromStringWithTryParse()
{
    Console.WriteLine("-> Parsing with TryParse()");
    string booleanString = "Hello";
    if (bool.TryParse(booleanString, out bool b))
    {
        Console.WriteLine("Value of B: {0}", b);
    }
    else
    {
        Console.WriteLine("Default value of B: {0}", b);
    }

    string doubleString = "9a345";
    if (double.TryParse(doubleString, out double d))
    {
        Console.WriteLine("Value of D: {0}", d);
    }
    else
    {
        Console.WriteLine("Failed to convert ({0}) to a double and the variable was assigned to the default ({1})", doubleString, d);
    }
}

static void ParseFromStrings()
{
    Console.WriteLine("-> Parsing");
    bool b = bool.Parse("TRUE");
    Console.WriteLine("Value of 'b': -> {0}", b);
    double d = double.Parse("99.333");
    Console.WriteLine("Value of 'd': -> {0}", d);
    int i = int.Parse("8");
    Console.WriteLine("Value of 'i': -> {0}", i);
    char c = char.Parse("W");
    Console.WriteLine("Value of 'c': -> {0}", c);
}

static void CharFunctionality()
{
    Console.WriteLine("-> Char type functionality");
    char myChar = 'a';
    Console.WriteLine("My character is: {0}", myChar);
    Console.WriteLine("Is lowercase? {0}", char.IsLower(myChar));
    Console.WriteLine("Is uppercase? {0}", char.IsUpper(myChar));
    Console.WriteLine("Is digit? {0}", char.IsDigit(myChar));
    Console.WriteLine("Is white space? {0}", char.IsWhiteSpace(myChar));
    Console.WriteLine("Is punctuation? {0}", char.IsPunctuation(myChar));
}

static void DataTypeFunctionality()
{
    Console.WriteLine("-> Data type functionality");

    Console.WriteLine("Int Min: {0}", System.Int32.MinValue);
    Console.WriteLine("Int Max: {0}", System.Int32.MaxValue);

    Console.WriteLine("Double Min: {0}", System.Double.MinValue);
    Console.WriteLine("Double Max: {0}", System.Double.MaxValue);

    Console.WriteLine("Double Epsilon: {0}", System.Double.Epsilon);
    Console.WriteLine("Double Positive Infinity: {0}", System.Double.PositiveInfinity);
    Console.WriteLine("Double Negative Infinity: {0}", System.Double.NegativeInfinity);

    // Some variables can be declared implicitly:
    var thisInteger = 1; // integer 
    var thisDouble = 2.0; // double
    var thisLong = 1L; // long
    var thisFloat = 5.333F; // float

    Console.WriteLine("{0} {1} {2} {3}", thisInteger, thisDouble, thisLong, thisFloat);

    // Booleans can only be true of false:
    bool thisBoolean1 = true;
    bool thisBoolean2 = false;
    Console.WriteLine("{0} {1}", thisBoolean1, thisBoolean2);

    Console.WriteLine(System.Boolean.TrueString);
    Console.WriteLine(System.Boolean.FalseString);

    string trueString = "True";

    if (System.Boolean.TrueString.Equals(trueString))
    {
        Console.WriteLine("This is true");
    }
}

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