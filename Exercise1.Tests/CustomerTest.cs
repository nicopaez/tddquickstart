using NUnit.Framework;

namespace Exercise1.Tests
{
    [TestFixture]
    public class CustomerTest
    {
        [Test]
        public void CustomerIsCreatedUnblocked()
        {
            var customer = new Customer("john");
            Assert.That(customer.IsBlocked, Is.False);
        }

        [Test]
        public void BlockSetCustomerToBlocked()
        {
            var customer = new Customer("john");
            customer.Block();
            Assert.That(customer.IsBlocked, Is.True);
        }
        
    }
}