ValueTypeAssignment();
ReferenceTypeAssignment();

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