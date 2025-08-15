using System;
using TUnit;

public class Hooks
{
  [Before(Assembly)]
  public static void Setup()
  {
    System.Console.WriteLine("Assembly Setup");
  }
}

public class Test1
{

  [Test]
  public void TestMethod1()
  {
    if (1 + 1 != 2)
    {
      throw new Exception("1 + 1 should equal 2");
    }
  }
}