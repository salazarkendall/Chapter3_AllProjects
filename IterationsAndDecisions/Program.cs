// Jumping Statements

string[] names = { "Kendall", "Alina", "Gilo", "Xinia", "Marcela", "Ronald" };
//JumpingStatements.BreakStatement(names);
//JumpingStatements.ContinueStatement(names);
//JumpingStatements.GotoStatement(names);
//JumpingStatements.ReturnStatement(names);
//JumpingStatements.ThrowStatement(names);

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
