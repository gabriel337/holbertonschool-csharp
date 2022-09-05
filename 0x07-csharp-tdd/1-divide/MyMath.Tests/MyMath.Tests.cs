using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSum()
        {
            var result = Operations.Add(1, 1);
            Assert.That(result, Is.EqualTo(2));

            result = Operations.Add(-1, -2);
            Assert.That(result, Is.EqualTo(-3));

            result = Operations.Add(0, 0);
            Assert.That(result, Is.EqualTo(0));

            result = Operations.Add(-3, 2);
            Assert.That(result, Is.EqualTo(-1));

            result = Operations.Add(3, -2);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}