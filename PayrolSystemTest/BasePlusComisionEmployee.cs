using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrolSystemTest
{
    public class BasePlusComisionEmployee : ComisionEmployee
    {
        private decimal basesalary;
        public BasePlusComisionEmployee(string firstname, string lastname, string socialsecuritynumber, decimal grossSales, decimal comisionRate, decimal basesalary) 
            : base(firstname, lastname, socialsecuritynumber, grossSales, comisionRate)
        {
            basesalary = basesalary;
        }
         // property that gets and sets BasePlusComissionEmployee's base salary
        public decimal BaseSalary { get => basesalary;
            set
            {
                if(value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(BaseSalary)} must be >= 0");
                }
                basesalary = value;
            }
        }

        // calculate earnings
        public override decimal Earnings() => BaseSalary + base.Earnings();

        // return string representation of BasePlusComissionEmployee
        public override string ToString() =>
            $"base-salaried {base.ToString()}\n" +
            $"base salary: {BaseSalary:C}";
    }
}
