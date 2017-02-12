using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Employee
    {
        private string _dateEmployed;
        public string Name { get; set; }

        public string DateHired
        {
            get { return _dateEmployed; }
        }
        public string Duty { get; set; }

        public abstract string EmployeeInfo();

        public abstract void PayRaise(double percent);
        //public abstract void Duty()

        protected Employee(string n, string d)
        {
            Name = n;
            _dateEmployed = d;
        }
    }
}
