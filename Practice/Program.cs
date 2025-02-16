// Arrays

// Declaracion e inicializaciones

// Declaracion, asignacion e inicializacion por separado
//int[] numbers; // Declaracion de la variable
//numbers = new int[2]; // Asignacion de espacio fijo
//numbers[0] = 0; // Llenado de espacios
//numbers[1] = 0; // Llenado de espacios

//int[] numbers = new[]{ 1, 2, 3, 4 }; // Inicializacion directa (con new)
//int[] numbers = { 1, 2, 3, 4 }; // Inicializacion implicita (sin new)
//int[] numbers = [1, 2, 3, 4]; // Inicializacion implicita en C# 12 (nueva sintaxis)
var numbers = new int[1, 2, 3, 4]; // Inicializacion usando var
//var numbers = [1, 2, 3, 4]; // A partir de C# 12
//int[] someNumbers = new int[5];
//Console.WriteLine(someNumbers[3]);
//Console.WriteLine(someNumbers[3].GetType().ToString()); // Asigna el valor default cuando no ha sido especificado

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

// Arrays multinivel:
// -> Array rectangular (Bidimensional)
int[,] matrix1 = new int[3, 3];
matrix1[1, 1] = 10000;
Console.WriteLine(matrix1[1, 1]);

// -> Jagged array
int[][] matrix2 = new int[3][];
matrix2[0] = [1, 2, 3, 4];
matrix2[1] = [5, 6, 7];
matrix2[2] = [9, 0, 1, 2, 8];


// Indices y Rangos
string[] phrase = ["Hola", "don", "Pepito", "hola", "don", "Jose"];

Console.WriteLine("Entire phrase:\n");
foreach (string word in phrase[..])
{
    Console.WriteLine(word);
}

Console.WriteLine("New phrase:\n");
foreach (string word in phrase[3..])
{
    Console.WriteLine(word);
}

Console.WriteLine("\nLast Word");
Console.WriteLine(phrase[^1]);

