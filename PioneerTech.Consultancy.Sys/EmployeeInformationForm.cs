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
                    employeeIDCompany.Items.Add(dr[0]);
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
            var firstName = textBoxFirstName.Text;
            var lastName = textBoxLastName.Text;
            var email = textBoxEmail.Text;
            var mobileNumber = Convert.ToInt64(textBoxMobile.Text);
            var alternateMobile = Convert.ToInt64(textBoxAlternateMobile.Text);
            var address1 = textBoxAddress1.Text;
            var address2 = textBoxAddress2.Text;
            var homeCountry = textBoxHomeCountry.Text;
            var currentCountry = textBoxCurrentCountry.Text;
            var zipCode = Convert.ToInt64(textBoxZipCode.Text);

            var conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source=BAIBHAV;" +
                "Initial Catalog=PioneerConsultancyDatabase;" +
                "Integrated security = True;";


            using (var com = conn.CreateCommand())
            {
                com.CommandText = "INSERT INTO EmployeeDetail" +
                                  "(FirstName, LastName, Email, ContactNumber, AlternateContactNumber, [Address], AlternateAddress, CurrentCountry, HomeCountry, Zipcode) " +
                                  "VALUES " +
                                  "(@firstName,@lastName,@email,@mobileNumber,@alternateMobile,@address1,@address2,@currentCountry,@homeCountry,@zipCode)";

                com.Parameters.AddWithValue("@firstName", firstName);
                com.Parameters.AddWithValue("@lastName", lastName);
                com.Parameters.AddWithValue("@email", email);
                com.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                com.Parameters.AddWithValue("@alternateMobile", alternateMobile);
                com.Parameters.AddWithValue("@address1", address1);
                com.Parameters.AddWithValue("@address2", address2);
                com.Parameters.AddWithValue("@currentCountry", currentCountry);
                com.Parameters.AddWithValue("@homeCountry", homeCountry);
                com.Parameters.AddWithValue("@zipCode", zipCode);
                conn.Open();

                var result = com.ExecuteNonQuery();

                MessageBox.Show(result > 0 ? "Message Saved Successfully" : "Message Did NOT Saved Successfully");

                conn.Close();

            }

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
            var projectName = projectNameTextBox.Text;
            var clientName = clientNameTextBox.Text;
            var place = placeTextBox.Text;
            var role = roleTextBox.Text;
            var employeeId = employeeIDComboBox.Text;

            var conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source=BAIBHAV;" +
                "Initial Catalog=PioneerConsultancyDatabase;" +
                "Integrated security = True;";


            using (var com = conn.CreateCommand())
            {
                com.CommandText = "INSERT INTO ProjectDetail VALUES(@projectName, @clientName,@place,@role,@employeeId)";
                 
                com.Parameters.AddWithValue("@projectName", projectName);
                com.Parameters.AddWithValue("@clientName", clientName);
                com.Parameters.AddWithValue("@place", place);
                com.Parameters.AddWithValue("@role", role);
                com.Parameters.AddWithValue("@employeeId",employeeId);

                conn.Open();
                var result = com.ExecuteNonQuery();

                MessageBox.Show(result > 0 ? "Message Saved Successfully" : "Message Did NOT Saved Successfully");

                conn.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var employerName = employerNameTextBox.Text;
            var contactNumber = contactNumberTextBox.Text;
            var place = placeCompany.Text;
            var website = websiteTextBox.Text;
            var employeeId = employeeIDCompany.Text;

            var conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source=BAIBHAV;" +
                "Initial Catalog=PioneerConsultancyDatabase;" +
                "Integrated security = True;";


            using (var com = conn.CreateCommand())
            {
                com.CommandText =
                    "INSERT INTO CompanyDetail VALUES(@employerName, @contactNumber,@place,@website,@employeeId)";

                com.Parameters.AddWithValue("@employerName", employerName);
                com.Parameters.AddWithValue("@contactNumber", contactNumber);
                com.Parameters.AddWithValue("@place", place);
                com.Parameters.AddWithValue("@website", website);
                com.Parameters.AddWithValue("@employeeId", employeeId);

                conn.Open();
                var result = com.ExecuteNonQuery();

                MessageBox.Show(result > 0 ? "Message Saved Successfully" : "Message Did NOT Saved Successfully");

                conn.Close();
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var UI = UITextBox.Text;
            var ProgrammingLanguage = ProgrammingLanguageTextBox.Text;
            var DatabaseName = DatabaseTextBox.Text;
            var ORM = ORMTextBox.Text;

            var employeeId = EmployeeIdTechnicalComboBox.Text;

            var conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source=BAIBHAV;" +
                "Initial Catalog=PioneerConsultancyDatabase;" +
                "Integrated security = True;";


            using (var com = conn.CreateCommand())
            {
                com.CommandText =
                    "INSERT INTO TechnicalDetail VALUES(@UI, @ProgrammingLanguage,@DatabaseName,@employeeId)";

                com.Parameters.AddWithValue("@UI", UI);
                com.Parameters.AddWithValue("@ProgrammingLanguage", ProgrammingLanguage);
                com.Parameters.AddWithValue("@DatabaseName", DatabaseName);
               // com.Parameters.AddWithValue("@ORM", ORM);
                com.Parameters.AddWithValue("@employeeId", employeeId);

                conn.Open();
                var result = com.ExecuteNonQuery();

                MessageBox.Show(result > 0 ? "Message Saved Successfully" : "Message Did NOT Saved Successfully");

                conn.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var CourseType = CourseTypeTextBox.Text;
            var YearOfPass = YearOfPassTextBox.Text;
            var CourseSpecialization = CourseSpecializationTextBox.Text;
            
            var employeeId = EmployeeIdEducationComboBox.Text;

            var conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source=BAIBHAV;" +
                "Initial Catalog=PioneerConsultancyDatabase;" +
                "Integrated security = True;";


            using (var com = conn.CreateCommand())
            {
                com.CommandText =
                    "INSERT INTO EducationDetail VALUES(@CourseType, @YearOfPass,@CourseSpecialization,@employeeId)";

                com.Parameters.AddWithValue("@CourseType", CourseType);
                com.Parameters.AddWithValue("@YearOfPass", YearOfPass);
                com.Parameters.AddWithValue("@CourseSpecialization",CourseSpecialization);
                com.Parameters.AddWithValue("@employeeId", employeeId);

                conn.Open();
                var result = com.ExecuteNonQuery();

                MessageBox.Show(result > 0 ? "Message Saved Successfully" : "Message Did NOT Saved Successfully");

                conn.Close();
            }
        }

    }
}

