ValueTypeAssignment();
ReferenceTypeAssignment();
ValueTypeContainingRefType();

static void ValueTypeContainingRefType()
{
  // Create the first rectangle
  Console.WriteLine("-> Creating Rectangle 1");
  Rectangle r1 = new("First Rectangle", 200, 200, 100, 100);

  // Now assign a new rectangle to r1:
  Console.WriteLine("-> Assigning r2 to r1");
  Rectangle r2 = r1;

  // Change some values of r2:
  Console.WriteLine("-> Changing values of r2");
  r1.RectInfo.InfoString = "This is new info";
  r2.RectBottom = 500;

  // Print values of both rectangles:
  r1.Display();
  r2.Display();
}

static void ValueTypeAssignment()
{
  Console.WriteLine("Assigning value types\n");
  PointStruct p1 = new PointStruct(10, 20);
  PointStruct p2 = p1;

  // Print both points:
  p1.Display();
  p2.Display();

  // Change p1.X and print again. p2.X is not changed
  p1.X = 100;
  Console.WriteLine("Changed p1.X");
  p1.Display();
  p2.Display();
}

static void ReferenceTypeAssignment()
{
  Console.WriteLine("Assigning reference types\n");
  PointRef p1 = new PointRef(10, 20);
  PointRef p2 = p1;

  // Print both points:
  p1.Display();
  p2.Display();

  // Change p1.X and print again. p2.X has changed!
  p1.X = 100;
  Console.WriteLine("Changed p1.X");
  p1.Display();
  p2.Display();
}

class PointRef
{
  public int X;
  public int Y;
  public PointRef(int posX, int posY) { X = posX; Y = posY; }
  public void Increment() { X++; Y++; }
  public void Decrement() { X--; Y--; }
  public void Display(string? message = null)
  {
    if (message != null) Console.WriteLine($"{message}");
    Console.WriteLine($"X = {X}, Y = {Y}");
  }
}

struct PointStruct
{
  public int X;
  public int Y;
  public PointStruct(int posX, int posY) { X = posX; Y = posY; }
  public void Increment() { X++; Y++; }
  public void Decrement() { X--; Y--; }
  public readonly void Display(string? message = null)
  {
    if (message != null) Console.WriteLine($"{message}");
    Console.WriteLine($"X = {X}, Y = {Y}");
  }
}

class ShapeInfo
{
  public string InfoString;
  public ShapeInfo(string info) { InfoString = info; }
}

struct Rectangle
{
  public ShapeInfo RectInfo;
  public int RectTop, RectBottom, RectLeft, RectRight;
  public Rectangle(string info, int top, int bottom, int left, int right)
  {
    RectInfo = new ShapeInfo(info);
    RectTop = top; RectBottom = bottom; RectRight = right; RectLeft = left;
  }
  public readonly void Display()
  {
    Console.WriteLine($"String: {RectInfo.InfoString}, Top: {RectTop}, Bottom: {RectBottom}, Right: {RectRight}, Left: {RectLeft}");
  }
}