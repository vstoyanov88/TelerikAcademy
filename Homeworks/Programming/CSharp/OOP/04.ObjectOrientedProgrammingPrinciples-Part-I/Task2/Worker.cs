using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Worker : Human
    {
        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = WeekSalary / (WorkHoursPerDay * 5.0);
            return moneyPerHour;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat("{0} {1} {2} {3} Money per hour {4}", this.FirstName.ToString(), this.LastName.ToString(),
                this.WeekSalary.ToString(), this.WorkHoursPerDay.ToString(),MoneyPerHour());
            return text.ToString();
        }
    }
}
