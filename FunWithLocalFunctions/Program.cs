EnterLogData(message: "This is an error", owner: "DB");
EnterLogData(message: "This is another");
EnterLogData(message: null);

static void EnterLogData(string message, string owner = "Programmer")
{
  if (message == null) throw new ArgumentNullException(message);
  Console.WriteLine("Error: {0}", message);
  Console.WriteLine("Owner of Error: {0}", owner);
}

static int AddWrapper(int x, int y)
{
  //Do some validation here
  return Add();
  int Add()
  {
    return x + y;
  }
}

static int AddWrapperWithSideEffect(int x, int y)
{
  //Do some validation here
  return Add();
  int Add()
  {
    x += 1;
    return x + y;
  }
}