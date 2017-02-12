using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class ProductionWorker: Employee
    {
        //only need properties unique to derived class
        public string Shift { get; set; }

        public double HourlyPayRate { get; set; }

        public override string EmployeeInfo()
        {
            return Name + " is hired on " +
                DateHired + ". Working on " +
                Shift + " for hourly rate of " +
                HourlyPayRate.ToString("c2");
        }

        public override void PayRaise(double percent)
        {
            HourlyPayRate = HourlyPayRate * (1 + percent / 100);
        }
        public ProductionWorker(string n, string d, string s, double h) :base(n, d)
        {
            Shift = s;
            HourlyPayRate = h;
        }

        }
    }

