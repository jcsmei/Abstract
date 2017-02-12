using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductionWorker Ted = new ProductionWorker("Ted", "January 3, 2015", "morning", 17.5);
        Manager John = new Manager("John", "October 10, 2001", 45000);

        private void btnWorkerTed_Click(object sender, EventArgs e)
        {
            //rtbDisplay.Text = Ted.EmployeeInfo();
            MessageBox.Show(Name + " is huird on " +
                 ". Working from 9 to 5 for annual salary of ");
        }

        private void btnManagerJohn_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = John.EmployeeInfo();
        }

        private void btnRaiseTed_Click(object sender, EventArgs e)
        {
            double r = double.Parse(txtInput.Text);
            Ted.PayRaise(r);
        }

        private void btnRaiseJohn_Click(object sender, EventArgs e)
        {
            double r = double.Parse(txtInput.Text);
            John.PayRaise(r);
        }
    }
}
