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
            ComisionRate = comisionRate;
        }

        public decimal GrossSales
        {
            get => grossSales;
            set
            {
                grossSales = value;
            }
        }
        public decimal ComisionRate
        {
            get => comisionRate;
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(ComisionRate)} must be > 0 and < 1");
                }
                comisionRate = value;
            }

        }

        public override decimal Earnings() => ComisionRate * GrossSales;

        public override string ToString() => $"cOMISION EMPLOYEE: {base.ToString()}\n" + $"gross sales: {GrossSales:C}\n" + $"Comision rate {ComisionRate:F2}";
    }
}
