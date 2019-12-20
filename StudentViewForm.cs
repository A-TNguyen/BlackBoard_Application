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
using System.Security.Cryptography.X509Certificates;
using Blackboard_Application.Connection;

namespace Blackboard_Application
{
    public partial class StudentViewForm : Form
    {
        

        public StudentViewForm()
        {
            InitializeComponent();
        }

        private void studentInformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentInfoDataSet);

        }

        private void StudentViewForm_Load(object sender, EventArgs e)
        {
            //Create SQL Source connection where your DB is locate
            //String source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Andrew Nguyen\\Documents\\Projects\\Blackboard_Application\\BlackBoard_Application\\StudentInfo.mdf;Integrated Security=True";
            
            var sqlClass = new SQLServerConnection(); // This calls the class for SQL

            sqlClass.OpenConnection(); // Open SQL connection
            
            //SQL query statement to select all information from studentinformation table where username is equal to the passing input from Login Form input
            string mySql = "SELECT * FROM StudentInformation WHERE username ='" + LoginForm.passingUsername + "'";
            
            //SqlClass.ExecuteQueries(mySql);
            
            var reader = sqlClass.DataReader(mySql);
            while (reader.Read()) //This if statement will pass ALL values into the textbox as a string to each one for the right username
            {
                school_IDTextBox.Text = (reader["School ID"].ToString());
                first_NameTextBox.Text = (reader["first_Name"].ToString());
                last_NameTextBox.Text = (reader["last_Name"].ToString());
                course_TakenTextBox.Text = (reader["Course Taken"].ToString());
                class_1_MidtermTextBox.Text = (reader["Class 1 Midterm"].ToString());
                class_2_MidtermTextBox.Text = (reader["Class 2 Midterm"].ToString());
                class_3_MidtermTextBox.Text = (reader["Class 3 Midterm"].ToString());
                class_4_MidtermTextBox.Text = (reader["Class 4 Midterm"].ToString());
                class_1_FinalsTextBox.Text = (reader["Class 1 Finals"].ToString());
                class_2_FinalsTextBox.Text = (reader["Class 2 Finals"].ToString());
                class_3_FinalsTextBox.Text = (reader["Class 3 Finals"].ToString());
                class_4_FinalsTextBox.Text = (reader["Class 4 Finals"].ToString());
                //statement create GPA calculation
                gPATextBox.Text = (reader["GPA"].ToString());
            }
            sqlClass.CloseConnection(); // closes the connection
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
              

            this.Hide(); // First need to hide main page
            LoginForm login = new LoginForm(); // Initialize LoginForm to a value
            login.ShowDialog(); //Enable you to go back to Login Page Form
            Application.Exit(); //Close out the form
        }

        private void school_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void afterloginbox_TextChanged(object sender, EventArgs e)
        {
            //afterloginbox.Text = LoginForm.passingUsername;
        }

        private void first_NameTextBox_TextChanged(object sender, EventArgs e)
        {
        
      
    }
    }
}
