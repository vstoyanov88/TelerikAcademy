using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal rate)
            : base(customer, balance, rate)
        { }

        public override decimal CalculateInerestRate(int months)
        {
            decimal getRate = 0;
            if (Customer.company == customer)
            {
                if (months > 12)
                {
                    getRate += this.rate * (months - 12) + (this.rate * 12 * 0.5m);
                }
                else
                {
                    getRate += this.rate * months / 0.5m;
                }
            }
            else
            {
                if (months > 6)
                {
                    getRate += this.rate * (months - 6);
                }
            }
            return getRate*100;
        }
    }
}
