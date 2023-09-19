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

        public decimal Basesalary 
        { 
            get => basesalary; 
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Basesalary)} must be >= 0");
                }

                basesalary = value;  

            }
        }

        public override decimal Earnings() => Basesalary + base.Earnings();

        public override string ToString() => base.ToString();
    }
}
