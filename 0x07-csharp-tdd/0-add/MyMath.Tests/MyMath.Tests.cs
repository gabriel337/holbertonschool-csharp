using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
       
        [Test]
        [TestCase(2,9)]
        [TestCase(-7, 5)]
        public void TestSum(int a, int b)
        {
            int result = Operations.Add(a, b);
        }
    }
}