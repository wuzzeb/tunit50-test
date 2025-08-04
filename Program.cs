using System;
using TUnit;
using System.Threading.Tasks;

public class Test1
{
  [Test]
  public async Task TestMethod1()
  {
    if (1 + 1 != 2)
    {
      throw new Exception("1 + 1 should equal 2");
    }

    var x = 1 + 1;
    await Assert.That(x).IsEqualTo(2);
  }
}