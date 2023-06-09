using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        
        [Test]
        [NUnit.Framework.Ignore("Beacause I wanted to!")]
        public void Add_WhenCalled_ReturnOfTheSumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }    
}
