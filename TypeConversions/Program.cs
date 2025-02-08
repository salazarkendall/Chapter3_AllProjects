Console.WriteLine("***** Fun with type conversions *****");
short numb1 = 30000, numb2 = 30000;
// Explicitly cast the int into a short (and allow loss of data).
short answer = (short)Add(numb1, numb2);
Console.WriteLine("{0} + {1} = {2}",
numb1, numb2, answer);
NarrowingAttempt();
Console.ReadLine();

static int Add(int x, int y)
{
  return x + y;
}

static void NarrowingAttempt()
{
  byte myByte;
  int myInt = 200;
  // Explicitly cast the int into a byte (no loss of data).
  myByte = (byte)myInt;
  Console.WriteLine("Value of myByte: {0}", myByte);
}