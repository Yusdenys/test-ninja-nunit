using NUnit.Framework;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(1, "1")]
        public void GetOutput_WhenCalled_ReturnString(int a, string expectedResult)
        {
            var result = FizzBuzz.GetOutput(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }    
}

