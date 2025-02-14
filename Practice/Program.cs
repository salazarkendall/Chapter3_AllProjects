// Arrays

// Declaracion e inicializaciones

// Declaracion, asignacion e inicializacion por separado
//int[] numeros; // Declaracion de la variable
//numeros = new int[2]; // Asignacion de espacio fijo
//numeros[0] = 0; // Llenado de espacios
//numeros[1] = 0; // Llenado de espacios

//int[] numeros = new[]{ 1, 2, 3, 4 }; // Inicializacion directa (con new)
//int[] numeros = { 1, 2, 3, 4 }; // Inicializacion implicita (sin new)
//int[] numeros = [1, 2, 3, 4]; // Inicializacion implicita en C# 12 (nueva sintaxis)
var numeros = new int[1, 2, 3, 4]; // Inicializacion usando var
                                   //var numeros = [1, 2, 3, 4]; // A partir de C# 12
//int[] varios = new int[5];
//Console.WriteLine(varios[3]);
//Console.WriteLine(varios[3].GetType().ToString()); // Asigna el valor default cuando no ha sido especificado

//foreach (int numero in numeros)
//{
//    Console.WriteLine(numero);
//}