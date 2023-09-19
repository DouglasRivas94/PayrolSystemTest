using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrolSystemTest
{
    public class HourlyEmployee : Employee
    {
        //HpurlyEmployee class that extend <Employee>
        private decimal wage; //sueldo por hora
        private decimal Hours; // horas trabajadas por semana
        public HourlyEmployee(string firstname, string lastname, string socialsecuritynumber, decimal hourlywage, decimal hoursworked)
            : base(firstname, lastname, socialsecuritynumber)
        {
            Wage = hourlywage;
            Hours = hoursworked;
        }

        //property taht get and set hourly employee´s wage
        public decimal Wage 
        {
            get => wage;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Wage)} must be => 0");
                }
                wage = value;
            }

        }

        //property that get and set hourly employee´s hours
        public decimal Hours1 
        { 
            get => Hours;
            set 
            {
                if(value < 0 || value > 168)
                {
                    throw new ArgumentOutOfRangeException(nameof(value)), value, $"{nameof(Hours1)}must be >=0 and <=168");
                }
                Hours = value; 
            }
        }

        public override decimal Earnings()
        {
            if (Hours <= 40)//no overtime
                return Wage * Hours1;
            else
                return (40 * Wage) + (Hours1 - 40) + Wage * 1.5M;
        }
        //return string representation of hourlyEmployee object
        public override string ToString()=> $"Hourly employee: {base.ToString()}\n" + $"hourly wage: {Wage:C}\n hours worked: {Hours1:F2}";
    }
}
