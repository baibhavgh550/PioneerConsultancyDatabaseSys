using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PioneerTech.Consultancy.Sys
{
    public partial class EmployeeDashboard : Form
    {

        private readonly int _employeeId;
        public EmployeeDashboard()
        {
            InitializeComponent();
            
        }

        public EmployeeDashboard(int employeeId)
        {
           InitializeComponent();
            _employeeId = employeeId;
            gridDisplay();

        }
        private void gridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void gridDisplay()
        {
            EmployeeInformationForm employeeInformationForm = new EmployeeInformationForm();


            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = BAIBHAV;database = PioneerConsultancyDatabase;Integrated security = SSPI";


            SqlCommand cmd = new SqlCommand("SELECT * FROM EmployeeDetail WHERE EmployeeID = " + _employeeId, mysqlconnection);

            mysqlconnection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource source1 = new BindingSource();
            source1.DataSource = dr;
            gridViewEmployee.DataSource = source1;
            dr.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM CompanyDetail WHERE EmployeeID = " + _employeeId, mysqlconnection);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            BindingSource source2 = new BindingSource();
            source2.DataSource = dr2;
            gridViewCompany.DataSource = source2;
            dr2.Close();

            SqlCommand cmd3 = new SqlCommand("SELECT * FROM ProjectDetail WHERE EmployeeID = " + _employeeId, mysqlconnection);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            BindingSource source3 = new BindingSource();
            source3.DataSource = dr3;
            gridViewProject.DataSource = source3;
            dr3.Close();

            mysqlconnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
          
            EmployeeInformationForm employeeInformationForm = new EmployeeInformationForm();


            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = BAIBHAV;database = PioneerConsultancyDatabase;Integrated security = SSPI";

           
            SqlCommand cmd = new SqlCommand("SELECT * FROM EmployeeDetail WHERE EmployeeID = "+_employeeId, mysqlconnection);
            
            mysqlconnection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource source1 = new BindingSource();
            source1.DataSource = dr;
            gridViewEmployee.DataSource = source1;
            dr.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM CompanyDetail WHERE EmployeeID = " + _employeeId, mysqlconnection);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            BindingSource source2 = new BindingSource();
            source2.DataSource = dr2;
            gridViewCompany.DataSource = source2;
            dr2.Close();

            SqlCommand cmd3 = new SqlCommand("SELECT * FROM ProjectDetail WHERE EmployeeID = " + _employeeId, mysqlconnection);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            BindingSource source3 = new BindingSource();
            source3.DataSource = dr3;
            gridViewProject.DataSource = source3;
            dr3.Close();

            mysqlconnection.Close();
        }
    }
}
