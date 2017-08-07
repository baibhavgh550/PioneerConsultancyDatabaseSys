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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
