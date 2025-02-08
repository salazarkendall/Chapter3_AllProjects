// Jumping Statements

string[] names = { "Kendall", "Alina", "Gilo", "Xinia", "Marcela", "Ronald" };
//JumpingStatements.BreakStatement(names);
//JumpingStatements.ContinueStatement(names);
//JumpingStatements.GotoStatement(names);
//JumpingStatements.ReturnStatement(names);
//JumpingStatements.ThrowStatement(names);
//IfElsePatternMatching();
//IfElsePatternMatchingUpdatedInCSharp9();
Console.WriteLine(FromRainbow("Red"));
Console.ReadLine();

static string FromRainbow(string colorBand)
{
    return colorBand switch
    {
        "Red" => "#FF0000",
        "Orange" => "#FF7F00",
        "Yellow" => "#FFFF00",
        "Green" => "#00FF00",
        "Blue" => "#0000FF",
        "Indigo" => "#4B0082",
        "Violet" => "#9400D3",
        _ => "#FFFFFF",
    };
}

static void TernaryOperator()
{
    string stringData = "My textual data";
    Console.WriteLine(stringData.Length > 0
    ? "string is greater than 0 characters"
    : "string is not greater than 0 characters");
    Console.WriteLine();

    // compiller error
    //stringData.Length > 0
    //? Console.WriteLine("string is greater than 0 characters")
    //: Console.WriteLine("string is not greater than 0 characters");
}

static void IfElsePatternMatchingUpdatedInCSharp9()
{
    Console.WriteLine("======= C# 9 If Else Pattern Matching Improvements =======");
    
    object testItem1 = 123;
    Type t = typeof(string);
    char c = 'f';
    //Type patterns
    if (t is Type)
    {
        Console.WriteLine($"{t} is a Type");
    }
    //Relational, Conjuctive, and Disjunctive patterns
    if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
    {
        Console.WriteLine($"{c} is a character");
    };
    //Parenthesized patterns
    if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
    {
        Console.WriteLine($"{c} is a character or separator");
    };
    //Negative patterns
    if (testItem1 is not string)
    {
        Console.WriteLine($"{testItem1} is not a string");
    }
    if (testItem1 is not null)
    {
        Console.WriteLine($"{testItem1} is not null");
    }
    Console.WriteLine();
}

static void IfElsePatternMatching()
{
    object test1 = "String 1";
    if(test1 is string) Console.WriteLine($"test1 is string: {test1}");
    if(test1 is string myTest1) Console.WriteLine($"test1 is string: {test1}, {myTest1}");
}

static class JumpingStatements
{
    // Will stop the loop when the condition is met
    public static void BreakStatement(string[] names)
    {
        foreach (var name in names)
        {
            if (name.Equals("Gilo")) break;
            Console.WriteLine(name);
        }
        Console.ReadLine();
    }

    // Will skip current iteration when the condition is met
    public static void ContinueStatement(string[] names)
    {
        foreach (var name in names)
        {
            if (name.Equals("Gilo")) continue;
            Console.WriteLine(name);
        }
        Console.ReadLine();
    }

    // Will go to specific code block when the condition is met
    public static void GotoStatement(string[] names)
    {
        foreach (var name in names)
        {
            if (name.Equals("Gilo")) goto theEnd;
            Console.WriteLine(name);
        }
        theEnd:
        Console.ReadLine();
    }

    // Will stop the execution of the entire method when the condition is met
    public static void ReturnStatement(string[] names)
    {
        foreach (var name in names)
        {
            if (name.Equals("Gilo")) return;
            Console.WriteLine(name);
        }
        Console.ReadLine();
    }

    // Will stop the execution of the entire project when the condition is met (if unhandled)
    public static void ThrowStatement(string[] names)
    {
        foreach (var name in names)
        {
            if (name.Equals("Gilo")) throw new ApplicationException();
            Console.WriteLine(name);
        }
        Console.ReadLine();
    }
}
