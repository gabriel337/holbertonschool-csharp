using NUnit.Framework;
using System.Collections.Generic;
using System;

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
        public void EmptyList()
        {
            List<int> nums = new List<int>();
            int output = MyMath.Operations.Max(nums);
            Assert.That(output, Is.EqualTo(0));
        }
    }
}