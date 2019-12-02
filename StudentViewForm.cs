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
            // TODO: This line of code loads data into the 'studentInfoDataSet.StudentInformation' table. You can move, or remove it, as needed.
            //this.studentInformationTableAdapter.Fill(this.studentInfoDataSet.StudentInformation);
            //Create SQL Source connection where your DB is locate
            String source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Andrew Nguyen\\Documents\\Projects\\Blackboard_Application\\BlackBoard_Application\\StudentInfo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source); //SQL connection
            con.Open();
            //SQL query statement to select all information from studentinformation table where username is equal to the passing input from Login Form input
            String mySQL = "SELECT * FROM StudentInformation WHERE username ='" + LoginForm.passingUsername + "'";
            SqlCommand cmd = new SqlCommand(mySQL,con);
            SqlDataReader dr = cmd.ExecuteReader(); //This is to read the SQL statements
            if(dr.Read()) //This if statement will pass ALL values into the textbox as a string to each one for the right username
            {
                school_IDTextBox.Text = (dr["School ID"].ToString());
                first_NameTextBox.Text = (dr["first_Name"].ToString());
                last_NameTextBox.Text = (dr["last_Name"].ToString());
                course_TakenTextBox.Text = (dr["Course Taken"].ToString());
                class_1_MidtermTextBox.Text = (dr["Class 1 Midterm"].ToString());
                class_2_MidtermTextBox.Text = (dr["Class 2 Midterm"].ToString());
                class_3_MidtermTextBox.Text = (dr["Class 3 Midterm"].ToString());
                class_4_MidtermTextBox.Text = (dr["Class 4 Midterm"].ToString());
                class_1_FinalsTextBox.Text = (dr["Class 1 Finals"].ToString());
                class_2_FinalsTextBox.Text = (dr["Class 2 Finals"].ToString());
                class_3_FinalsTextBox.Text = (dr["Class 3 Finals"].ToString());
                class_4_FinalsTextBox.Text = (dr["Class 4 Finals"].ToString());
                //statement create GPA calculation
                gPATextBox.Text = (dr["GPA"].ToString());
            }
            con.Close(); //Close connection
            
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
