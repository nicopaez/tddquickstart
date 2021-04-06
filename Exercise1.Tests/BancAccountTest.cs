using System;
using NUnit.Framework;
using Exercise1;

namespace Exercise1.Tests
{
    public class BancAccountTest
    {
        private BackAccount backAccount;
        private Customer customer;

        [SetUp]
        public void SetUp()
        {
            this.customer = new Customer("John");
            this.backAccount = new BackAccount(customer);   
        }
        
        [Test]
        public void BankAccountIsCreatedWithBalanceZero()
        {
            Assert.That(backAccount.Balance, Is.EqualTo((0)));
        }

        [Test]
        public void CreditIncrementsBalanceToCorrectAmount()
        {
            backAccount.AddCredit(100);
            Assert.That(backAccount.Balance, Is.EqualTo(100));
        }
        
        [Test]
        public void WithdrawDecrementsBalanceWhenAmountIsLessThanBalance()
        {
            backAccount.AddCredit(100);
            backAccount.Withdraw(10);

            Assert.That(backAccount.Balance, Is.EqualTo(90));
        }

        [Test]
        public void WithdrawThrowsExeptionWhenAmountIsGreaterThanBalance()
        {
            Assert.Throws<BalanceExceededException>(() => backAccount.Withdraw(10));
        }

        [Test, Ignore("Temporal while we work on customer")]
        public void dog()
        {
            this.customer.Block();
            Assert.Throws<InvalidOperationException>(() => backAccount.Withdraw(10));
        }
    }
}