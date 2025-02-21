Punto p1 = new(10, 20);
p1.Display();
ModificarPunto(ref p1);
p1.Display();

static void ModificarPunto(ref Punto punto) { punto.X = 9999; }
struct Punto
{
  public int X;
  public int Y;
  public Punto(int pX, int pY) { X = pX; Y = pY; }
  public readonly void Display() { Console.WriteLine($"X: {X}, Y: {Y}"); }
}
