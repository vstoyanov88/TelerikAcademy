//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.
//Customers could be individuals or companies. All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated 
//as follows: number_of_months * interest_rate. Loan accounts have no interest for the first 3 months if 
//are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces. You should identify 
//the classes, interfaces, base classes and abstract actions and implement the calculation of the interest
//functionality through overridden methods.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Program
    {
        static void Main()
        {
            DepositAccount depos = new DepositAccount(Customer.company,125.66m,0.06m);
            Console.WriteLine(depos);
            depos.Deposite(1);
            Console.WriteLine(depos);
            depos.Draw(2);
            Console.WriteLine(depos);
            Console.WriteLine(depos.CalculateInerestRate(12));
            depos.Deposite(1000);
            Console.WriteLine(depos.CalculateInerestRate(12));

            LoanAccount loan = new LoanAccount(Customer.company, 12m, 0.055m);
            loan.Deposite(500);
            Console.WriteLine(loan.CalculateInerestRate(5));

            MortgageAccount mort = new MortgageAccount(Customer.individual, 100m, 0.05m);
            Console.WriteLine(mort.CalculateInerestRate(7));

            Account[] accounts = new Account[] { depos, loan, mort };
            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
        }
    }
}
