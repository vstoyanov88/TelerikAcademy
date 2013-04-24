using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class DepositAccount : Account, IDrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal rate)
            : base(customer, balance, rate)
        { }

        public void Draw(decimal sum)
        {
            this.balance -= sum;
        }

        public override decimal CalculateInerestRate(int months)
        {
            if (balance > 1000)
            {
                return this.rate*months*100;
            }
            else
            {
                return 0;
            }
        }
    }
}
