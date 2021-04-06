using System;

namespace Exercise1
{
    public class BackAccount
    {
        private readonly Customer owner;

        public BackAccount(Customer owner)
        {
            this.owner = owner;
        }

        public int Balance { get; protected set; }

        public void AddCredit(int amount)
        {
            Balance += amount;
        }

        public void Withdraw(int amount)
        {
            if(this.owner.IsBlocked)
            {
                throw new InvalidOperationException();
            }

            if(amount > Balance)
            {
                throw new BalanceExceededException();
            }

            Balance -= 10;
        }
    }
}