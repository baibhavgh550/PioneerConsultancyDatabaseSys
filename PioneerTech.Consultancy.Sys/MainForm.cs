using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PioneerTech.Consultancy.Sys
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           EmployeeInformationForm  employeeInformationForm = new EmployeeInformationForm();
            employeeInformationForm.Show();

        }

        public void viewEmployee_click(object sender, EventArgs e)
        {
            var employeeID = Convert.ToInt32(textBoxViewEmployee.Text);
            var employeeDashboardForm= new EmployeeDashboard(employeeID);
            employeeDashboardForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
