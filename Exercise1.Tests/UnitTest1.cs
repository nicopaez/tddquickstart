using NUnit.Framework;
using Exercise1;

namespace Exercise1.Tests
{
    public class Tests
    {
        [Test]
        public void BankAccountIsCreatedWithBalanceZero()
        {
            // Arrange
            var customer = new Customer("John");
            
            // act
            var backAccount = new BackAccount(customer);
            
            // assert
            Assert.That(backAccount.Balance, Is.EqualTo((0)));
        }
    }
}