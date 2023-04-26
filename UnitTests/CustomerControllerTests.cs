
using NUnit.Framework;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController? _controller;
        
        [SetUp]
        public void SetUp()
        {
            _controller = new CustomerController();
        }
        
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var result = _controller?.GetCustomer(0);
            //TypeOf verify if the object is NotFound
            Assert.That(result, Is.TypeOf<NotFound>());
            
            //InstanceOf verify if is NotFound object or derivates
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }
        
        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var result = _controller?.GetCustomer(1);
            
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }    
    
}
