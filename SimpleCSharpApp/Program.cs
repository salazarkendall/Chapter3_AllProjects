class Program
{
    static int Main(string[] args)
    {
        Console.Title = "Console Practice";

        // Note we are explicitly returning an int, rather than void.
        // Display a message and wait for Enter key to be pressed.
        Console.WriteLine("***** My First C# App *****");
        Console.WriteLine("Hello World!");
        Console.WriteLine();

        // Get arguments using System.Environment
        string[] theArgs = Environment.GetCommandLineArgs();
        foreach (string arg in theArgs)
        {
            Console.WriteLine("The arg: {0}", arg);
        }

        // Process any incoming args.
        foreach (string arg in args)
        {
            Console.WriteLine("Arg: {0}", arg);
        }

        ShowSystemInfo();

        Console.ReadLine();
        Console.Beep();
        // Return an arbitrary error code.
        return 0;
    }

    static void ShowSystemInfo()
    {
        foreach (var drive in Environment.GetLogicalDrives())
        {
            Console.Beep();
            Console.WriteLine("Drive: {0}", drive);
        }


        Console.WriteLine("OS: {0}", Environment.OSVersion);
        Console.WriteLine("Processor Count: {0}", Environment.ProcessorCount);
        Console.WriteLine("Dotnet Version: {0}", Environment.Version);
        Console.WriteLine("Is 64bit OS: {0}", Environment.SystemDirectory);
    }
}