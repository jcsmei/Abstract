using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Manager: Employee
    {
        public double AnnualSalary { get; set; }

        public override string EmployeeInfo()
        {
            return Name + " is huird on " +
                DateHired + ". Working from 9 to 5 for annual salary of " +
                AnnualSalary.ToString("c2");
        }
        public override void PayRaise(double percent)
        {
            AnnualSalary = AnnualSalary * (1 + percent / 100);
        }
        public Manager( string n, string d, double a) :base(n, d)
        {
            AnnualSalary = a;
        }
    }
    }
    

