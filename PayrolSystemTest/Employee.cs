using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrolSystemTest
{
    //Employee abstract base class
    public abstract class Employee : IPayable
    {
        public string Firstname { get; }
        public string Lastname { get; }
        public string SocialSecurityNumber { get; }

        //Three parameter constructor
        public Employee(string firstname, string lastname, string socialsecuritynumber)
        {
            Firstname = firstname;
            Lastname = lastname;
            SocialSecurityNumber = socialsecuritynumber;
        }

        //return string representation of employee object, using properties
        public override string ToString() => $"{Firstname} {Lastname}\n"+$"Social Security Number: {SocialSecurityNumber}";

        //abstract method override by derived classes
        public abstract decimal Earnings(); //no implementation here

        //implementing GetPaymentAmount here enables the entire employee
        //Class hierarchy to be used in an app that process IPayables
        public decimal GetPaymentAmount() => Earnings();
    }
}
