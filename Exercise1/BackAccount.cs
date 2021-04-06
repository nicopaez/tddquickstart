namespace Exercise1
{
    public class BackAccount
    {
        public BackAccount(Customer owner)
        {

        }

        public int Balance { get; protected set; }

        public void AddCredit(int amount)
        {
            Balance += amount;
        }

        public void Withdraw(int amount)
        {
            if(amount > Balance)
            {
                throw new BalanceExceededException();
            }

            Balance -= 10;
        }
    }
}