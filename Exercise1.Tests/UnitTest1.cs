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

        [Test]
        public void CreditIncrementsBalanceToCorrectAmount()
        {
            var customer = new Customer("John");
            
            var backAccount = new BackAccount(customer);

            backAccount.AddCredit(100);

            Assert.That(backAccount.Balance, Is.EqualTo(100));
        }
    }
}