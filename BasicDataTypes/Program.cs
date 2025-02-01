Console.WriteLine("**** Fun with Basic Data Types ****");
LocalVarDeclarations();

static void DefaultDeclarations()
{

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