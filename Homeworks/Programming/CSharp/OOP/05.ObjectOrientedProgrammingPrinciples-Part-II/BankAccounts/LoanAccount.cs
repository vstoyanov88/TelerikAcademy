using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal rate)
            : base(customer, balance, rate)
        { }

        public override decimal CalculateInerestRate(int months)
        {
            decimal getRate = 0;
            if (Customer.individual==customer && months>3)
            {
                getRate += this.rate * (months-3);
            }
            else if (Customer.company == customer && months > 2)
            {
                getRate += this.rate * (months-2);
            }
            return getRate*100;
        }
    }
}
