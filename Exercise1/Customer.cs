using System;

namespace Exercise1
{
    public class Customer
    {
        public Customer(string customerName)
        {
            this.IsBlocked = false;
        }

        public void Block()
        {

        }

        public bool IsBlocked { get; protected set; }
    }
}