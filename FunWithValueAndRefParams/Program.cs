// Regla de oro:
// -> Si un reference type es pasado by reference, dentro del metodo se pueden cambiar
//    las propiedades del objeto, ademas de la referencia al objeto que apunta.
// -> Si un reference type es pasado by value, dentro del metodo se pueden cambiar
//    las propiedades del objeto pero no el objeto al que se hace referencia.

Console.WriteLine("-> Passing Person object by value");
Person Stanley = new("Stanley", 65);
Console.WriteLine(" -> Before by value call, Person is:");
Stanley.Display();

SendPersonByValue(Stanley);
Console.WriteLine(" -> After by value call, Person is:");
Stanley.Display();

Console.WriteLine("-> Passing Person object by value");
Person Jim = new("Jim", 34);
Console.WriteLine(" -> Before by reference call, Person is:");
Jim.Display();

SendPersonByReference(ref Jim);
Console.WriteLine(" -> After by reference call, Person is:");
Jim.Display();

static void SendPersonByValue(Person person)
{
  person.PersonAge = 99;
  person = new Person("Garrison", 66);
}

static void SendPersonByReference(ref Person person)
{
  person.PersonAge = 99;
  person = new Person("Garrison", 66);
}

class Person
{
  public string PersonName { get; set; }
  public int PersonAge { get; set; }
  public Person(string name, int age)
  {
    PersonName = name;
    PersonAge = age;
  }
  public void Display() { Console.WriteLine($"Name: {PersonName}, Age: {PersonAge}"); }
}