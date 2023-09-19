﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrolSystemTest
{
    //Employee abstract base class
    public abstract class Employee
    {
        public string Firstname { get; }
        public string Lastname { get; }
        public string SocialSecurityNumber { get; }

        //Three parameter constructor
        public Employee(string firstname, string lastname, string socialsecuritynumber)
        {
            firstname = firstname;
            lastname = lastname;
            SocialSecurityNumber = socialsecuritynumber;
        }

        //return string representation of employee object, using properties
        public override string ToString() => $"{Firstname} {Lastname}\n"+$"Social Security Number: {SocialSecurityNumber}";

        //abstract method override by derived classes
        public abstract decimal Earnings(); //no implementation here
    }
}