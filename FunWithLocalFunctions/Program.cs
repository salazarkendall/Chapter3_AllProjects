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