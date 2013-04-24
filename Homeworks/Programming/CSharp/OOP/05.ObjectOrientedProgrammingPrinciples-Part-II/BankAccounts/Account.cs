using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public abstract class Account : IDepositable
    {
        public Customer customer { get; protected set; }
        protected decimal balance;
        protected decimal rate;

        public Account(Customer customer, decimal balance, decimal rate)
        {
            this.customer = customer;
            this.balance = balance;
            this.rate = rate;
        }

        public decimal Balance 
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal Rate
        {
            get { return this.rate; }
            set { this.rate = value; }
        }

        public void Deposite(decimal sum)
        {
            this.balance += sum;
        }

        public virtual decimal CalculateInerestRate(int months)
        {
            return this.rate * months*100;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat(" {0}\n Customer - {1}\n Balance - {2}\n Rate - {3}\n",this.GetType(), this.customer, this.balance, this.rate);
            return text.ToString();
        }
    }
}
