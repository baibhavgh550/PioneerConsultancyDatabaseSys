using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyClassLibraryProject.Model;
using PioneerTech.Consultancy.DAL;
using PioneerTech.Models.Model;


namespace PioneerTech.Consultancy.Sys
{
    public partial class EmployeeInformationForm : Form
    {
        public EmployeeInformationForm()
        {
            InitializeComponent();
            var conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source=BAIBHAV;" +
                "Initial Catalog=PioneerConsultancyDatabase;" +
                "Integrated security = True;";


            using (var com = conn.CreateCommand())
            {
                conn.Open();
                com.CommandText = "SELECT EmployeeID FROM EmployeeDetail";

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    employeeIDComboBox.Items.Add(dr[0]);
                    EmployeeIdComboBoxTextBox.Items.Add(dr[0]);
                    EmployeeIdTechnicalComboBox.Items.Add(dr[0]);
                    EmployeeIdEducationComboBox.Items.Add(dr[0]);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            var employeeModel = new EmployeeModel()
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                EmailId = textBoxEmail.Text,
                MobileNumber = Convert.ToInt64(textBoxMobile.Text),
                AlternateMobile = Convert.ToInt64(textBoxAlternateMobile.Text),
                Address1 = textBoxAddress1.Text,
                Address2 = textBoxAddress2.Text,
                HomeCountry = textBoxHomeCountry.Text,
                CurrentCountry = textBoxCurrentCountry.Text,
                ZipCode = Convert.ToInt64(textBoxZipCode.Text)
            };

            var employeeDataAccessLayer = new EmployeeDataAccessLayer();
            var result = employeeDataAccessLayer.SaveEmployeeDetails(employeeModel);

            MessageBox.Show(result > 0 ? "Message Saved Successfully" : "Message Did NOT Saved Successfully");

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var employeeDataAccessLayer = new EmployeeDataAccessLayer();

            var employeeId = employeeIDComboBox.Text;
            var projectModel = new ProjectModel
            {
                ProjectName = projectNameTextBox.Text,
                ClientName = clientNameTextBox.Text,
                Place = placeTextBox.Text,
                Role = roleTextBox.Text,

            };

            var result = employeeDataAccessLayer.SaveProjectDetails(projectModel);
            MessageBox.Show(result > 0 ? "Message Saved Successfully" : "Message Did NOT Saved Successfully");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var companyModel = new CompanyModel
            {
                EmployerName = employerNameTextBox.Text,
                ContactNumber = clientNameTextBox.Text,
                Place = placeTextBox.Text,
                Website = roleTextBox.Text,
                EmployeeId = Convert.ToInt32(EmployeeIdComboBoxTextBox.Text)
            };
            var employeeDataAccessLayer = new EmployeeDataAccessLayer();
            var result = employeeDataAccessLayer.SaveCompanyDetails(companyModel);
            MessageBox.Show(result > 0 ? "Message Saved Successfully" : "Message Did NOT Saved Successfully");
        }


        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var technicalModel = new TechnicalModel()
            {
                UI = UITextBox.Text,
                ProgrammingLanguage = ProgrammingLanguageTextBox.Text,
                Database = DatabaseTextBox.Text,
                EmployeeId = Convert.ToInt32(EmployeeIdTechnicalComboBox.Text)
            };
            var employeeDataAccessLayer = new EmployeeDataAccessLayer();
            var result = employeeDataAccessLayer.SaveTechnicalDetails(technicalModel);
            MessageBox.Show(result > 0 ? "Message Saved Successfully" : "Message Did NOT Saved Successfully");
        }

    private void button6_Click(object sender, EventArgs e)
    {
    EducationModel educationModel = new EducationModel
    {
        CourseType = CourseTypeTextBox.Text,
        YearOfPass = YearOfPassTextBox.Text,
        CourseSpecialization = CourseSpecializationTextBox.Text,
        EmployeeId = Convert.ToInt32(EmployeeIdEducationComboBox.Text)
    };

    var employeeDataAccessLayer = new EmployeeDataAccessLayer();
    var result = employeeDataAccessLayer.SaveEducationDetail(educationModel);

    MessageBox.Show(result > 0 ? "Message Saved Successfully" : "Message Did NOT Saved Successfully");
    }

    private void employeeIDCompany_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

}