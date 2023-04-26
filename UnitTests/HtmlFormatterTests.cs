using NUnit.Framework;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        private HtmlFormatter? _htmlFormatter;

        [SetUp]
        public void SetUp()
        {
            _htmlFormatter = new HtmlFormatter();
        }
        
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var result = _htmlFormatter?.FormatAsBold("abc");
            //Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);
            
            //General
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            Assert.That(result, Does.Contain("abc").IgnoreCase);
        }
    }    
}

