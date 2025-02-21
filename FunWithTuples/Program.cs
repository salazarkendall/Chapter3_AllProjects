
// Tuples
(string, int, string) valuesTuple1 = ("Hola", 12, "Mundo");
var valuesTuple2 = ("Hola", 12, "Mundo");

// El compilador agrega ItemX en tiempo de desarrollo
// Incluso intuye el tipo
Console.WriteLine($"First item: {valuesTuple1.Item1}");
Console.WriteLine($"Second item: {valuesTuple1.Item2}");
Console.WriteLine($"Third item: {valuesTuple1.Item3}");

// Los valores pueden ser nombrados en el lado izquierdo o derecho
(string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 5, "c");
var valuesWithNames2 = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");

// En ambos casos, Custom1 y Custom2 van a ser ignorados
// Siempre se toma en cuenta el lado izquierdo, al menos que sea definido como var
(int, int) example = (Custom1: 5, Custom2: 7);
(int Field1, int Field2) example2 = (Custom1: 5, Custom2: 7);

Console.WriteLine("=> Inferred Tuple Names");
var foo = new { Prop1 = "first", Prop2 = 12 }; // Btw, foo es un "tipo anonimo"
var bar = (foo.Prop1, foo.Prop2);
Console.WriteLine($"{bar.Prop1};{bar.Prop2}");
Console.WriteLine($"{bar.Prop1.GetType()};{bar.Prop2.GetType()}");

// Estas propiedades ahora son accesibles:
Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");
// La notacion ItemX tambien siguie funcionando
Console.WriteLine($"First item: {valuesWithNames.Item1}");
Console.WriteLine($"Second item: {valuesWithNames.Item2}");
Console.WriteLine($"Third item: {valuesWithNames.Item3}");

var nt = (5, 4, ("a", "b"));
Console.WriteLine($"Third item: {nt.Item3.Item1}");

(long a, int b) longFirst = (5, 10);
(int a, long b) longSecond = (5, 10);
Console.WriteLine(longFirst == longSecond); // Also true

FillTheseValues(out int _, out bool _, out char c);
Console.WriteLine($"c value -> {c}");

var samples = FillTheseValues2();
Console.WriteLine($"c value -> {samples.c}");

var (_, myBool, _) = FillTheseValues2();
Console.WriteLine($"b value -> {myBool}");

var myFullName = "Kendall Salazar";
var splittedName = SplitName(myFullName);
Console.WriteLine($"My name is: {splittedName.name}");

// Sin tuples
static void FillTheseValues(out int a, out bool b, out char c)
{
  a = 1;
  b = false;
  c = 'C';
}

// Con tuples
static (int a, bool b, char c) FillTheseValues2()
{
  return (a: 1, b: false, c: 'C');
}

static (string name, string lastName) SplitName(string fullName)
{
  string name = "", lastName = "";
  string[] splittedName = fullName.Split("");
  if (splittedName.Length == 2)
  {
    name = splittedName[0];
    lastName = splittedName[1];
  }
  return (name, lastName);
}