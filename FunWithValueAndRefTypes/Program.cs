ValueTypeAssignment();

static void ValueTypeAssignment()
{
  Console.WriteLine("Assigning value types\n");
  Point p1 = new Point(10, 20);
  Point p2 = p1;

  // Print both points:
  p1.Display();
  p2.Display();

  // Change p1.X and print again. p2.X is not changed
  p1.X = 100;
  p1.Display();
  p2.Display();
}

struct Point
{
  public int X = 4;
  public int Y = 6;
  public Point() { }
  public Point(int posX, int posY)
  {
    X = posX;
    Y = posY;
  }
  public void Increment()
  {
    X++; Y++;
  }
  public void Decrement()
  {
    X--; Y--;
  }
  public readonly void Display(string? message = null)
  {
    if (message != null) Console.WriteLine($"{message}");
    Console.WriteLine($"X = {X}, Y = {Y}");
  }
}