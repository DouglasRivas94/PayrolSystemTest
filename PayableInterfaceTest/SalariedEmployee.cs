using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    public class SalariedEmployee : Employee
    {
        //salariedEmployee class that extends Employee
        private decimal weeklySalary;

        //Four parameter constructor
        public SalariedEmployee(string firstname, string lastname, string socialsecuritynumber, decimal weeklysalary) : base(firstname, lastname, socialsecuritynumber)
        {
        }

        //Property that get and set salaried employee´s salary
        public decimal WeeklySalary 
        { 
            get => weeklySalary;
            set
            {
                if(value < 0)//validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(WeeklySalary)} must be >= 0");
                }
                weeklySalary = value;
            }
        }

        //claculate earnings; override abstract method earning in employee
        public override decimal Earnings() => WeeklySalary;

        //return string representation of SalariedEmployee object
        public override string ToString() => $"salaried employee: {base.ToString()}\n" + $"weekly salary: {WeeklySalary:C}";
    }
}
