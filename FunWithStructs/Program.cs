// Create an initial Point.
Point myPoint;
myPoint.X = 123;
myPoint.Y = 321;
myPoint.Display("Declare, then initialize:");

myPoint.Increment();
myPoint.Display("After increment");

Point newPoint = new();
newPoint.Display("Using empty constructor");

Point anotherPoint = new(23, 34);
anotherPoint.Display("Using custom constructor");

ReadOnlyPoint readOnlyPoint = new();
readOnlyPoint.Display("ReadOnlyPoint");

ReadOnlyPoint anotherReadOnlyPoint = new(52, 29);
anotherReadOnlyPoint.Display("AnotherReadOnlyPoint");

PointWithReadOnly pointWithReadOnly = new(31, 89, "Point with RO");
pointWithReadOnly.Display("Point with readonly");

// PointWithRef refPoint = new();

struct Point
{
  // Fields of the structure
  public int X = 4;
  public int Y = 6;

  public Point() { }

  public Point(int posX, int posY)
  {
    X = posX;
    Y = posY;
  }

  // Add 1 to the (X, Y) position
  public void Increment()
  {
    X++; Y++;
  }

  // Substract 1 from the (X, Y) position
  public void Decrement()
  {
    X--; Y--;
  }

  // Display the current position 
  public readonly void Display(string? message = null)
  {
    if (message != null) Console.WriteLine($"{message}");
    Console.WriteLine($"X = {X}, Y = {Y}");
  }
}

readonly struct ReadOnlyPoint
{
  public int X { get; }
  public int Y { get; }

  public ReadOnlyPoint(int posX, int posY)
  {
    X = posX;
    Y = posY;
  }
  public void Display(string? message = null)
  {
    if (message != null) Console.WriteLine($"{message}");
    Console.WriteLine($"X = {X}, Y = {Y}");
  }
}

struct PointWithReadOnly
{
  public int X;
  public readonly int Y;
  public readonly string Name;

  public PointWithReadOnly(int posX, int posY, string name)
  {
    X = posX;
    Y = posY;
    Name = name;
  }
  public readonly void Display(string? message = null)
  {
    if (message != null) Console.WriteLine($"{message}");
    Console.WriteLine($"X = {X}, Y = {Y}");
  }
}

ref struct PointWithRef
{
  public int X;
  public int Y;

  public void Point(int posX, int posY)
  {
    X = posX;
    Y = posY;
  }
}