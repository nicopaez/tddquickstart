namespace Exercise1 {
    
    using System;

    public class BalanceExceededException : Exception
    {
        public BalanceExceededException() : base("The amount withdrawn exceeds the balance")
        {
            
        }
    }
}