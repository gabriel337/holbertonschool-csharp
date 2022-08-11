namespace MyMath.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    public void TestSum([Values(2, 2)] int input)
    {
        Assert.AreEqual("2", output);
    }
}