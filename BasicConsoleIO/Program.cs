Console.WriteLine("***** Basic Console I/O *****");
GetUserData();
FormattingStrings();
Console.ReadLine();
static void GetUserData()
{
    Console.WriteLine("Please enter your name: ");
    var userName = Console.ReadLine();
    Console.WriteLine("Please enter your age: ");
    var userAge = Console.ReadLine();

    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);
    
    Console.ForegroundColor = prevColor;
}

static void FormattingStrings()
{
    string formattedString = string.Format("9999 formatted -> {0:f}", 10);
    Console.WriteLine(formattedString);
}