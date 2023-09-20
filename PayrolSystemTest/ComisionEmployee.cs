using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrolSystemTest
{
    public class ComisionEmployee : Employee
    {
        //comision employee class that extend Employee
        private decimal grossSales;
        private decimal comisionRate;
        public ComisionEmployee(string firstname, string lastname, string socialsecuritynumber, decimal grossSales, decimal comisionRate) : base(firstname, lastname, socialsecuritynumber)
        {
            GrossSales = grossSales;
            ComissionRate = comisionRate;
        }

        // property that gets and sets comission employee's groos sales
        public decimal GrossSales
        {
            get => grossSales;
            set
            {
                if (value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(GrossSales)} must be >= 0");
                }
                grossSales = value;
            }
        }

        // property that gets and sets comission employee's comission rate
        public decimal ComissionRate
        {
            get => comisionRate;
            set
            {
                if (value <= 0 || value >= 1) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(ComissionRate)} must be > 0 and < 1");
                }
                comisionRate = value;
            }
        }

        public override decimal Earnings() => ComissionRate * GrossSales;

        public override string ToString() => $"cOMISION EMPLOYEE: {base.ToString()}\n" + $"gross sales: {GrossSales:C}\n" + $"Comision rate {ComissionRate:F2}";
    }
}
