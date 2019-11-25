using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blackboard_Application.Connection;
using System.Data.SqlClient;

namespace Blackboard_Application
{
    public partial class AdminPageForm : Form
    {
        public AdminPageForm()
        {
            InitializeComponent();
        }
        public SqlConnection GetsqlCon()
        {
            string connstring = "Data Source=DESKTOP-F97OPVH\\ANDREWSQLEXPRESS;Initial Catalog = logindatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";//Persist Security Info=False";
            SqlConnection dbconn = new SqlConnection(connstring);
            return dbconn;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'update8DataBase.StudentInformation' table. You can move, or remove it, as needed.
            this.studentInformationTableAdapter.Fill(this.update8DataBase.StudentInformation);
            // TODO: This line of code loads data into the 'update8DataBase.StudentInformation' table. You can move, or remove it, as needed.
            this.studentInformationTableAdapter.Fill(this.update8DataBase.StudentInformation);
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); // First need to hide main page
            LoginForm login = new LoginForm(); // Initialize LoginForm to a value
            login.ShowDialog(); //Enable you to go back to Login Page Form
            this.Close(); // Make sure to close out this MainPage Window
            login.Dispose(); //Dispose the login after used

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        public bool grabCom(string connstring1)
        {
            try
            {
                SqlConnection sqlcon = this.GetsqlCon();
                SqlCommand sqlcomm = new SqlCommand(connstring1, sqlcon);
                sqlcon.Open();
                sqlcomm.ExecuteNonQuery();
                sqlcomm.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e) // Update Class
        {
          
            try
            {
                //Creates Variables for each columns
                string col1 = StudentGrid[0, StudentGrid.CurrentCell.RowIndex].Value.ToString();
                string col2 = StudentGrid[1, StudentGrid.CurrentCell.RowIndex].Value.ToString();
                string col3 = StudentGrid[2, StudentGrid.CurrentCell.RowIndex].Value.ToString();
                string col4 = StudentGrid[3, StudentGrid.CurrentCell.RowIndex].Value.ToString();
                string col5 = StudentGrid[4, StudentGrid.CurrentCell.RowIndex].Value.ToString();
                string col6 = StudentGrid[5, StudentGrid.CurrentCell.RowIndex].Value.ToString();
                string col7 = StudentGrid[6, StudentGrid.CurrentCell.RowIndex].Value.ToString();
                string col8 = StudentGrid[7, StudentGrid.CurrentCell.RowIndex].Value.ToString();
                string col9 = StudentGrid[8, StudentGrid.CurrentCell.RowIndex].Value.ToString();
                string col10 = StudentGrid[9, StudentGrid.CurrentCell.RowIndex].Value.ToString();
                string col11 = StudentGrid[10, StudentGrid.CurrentCell.RowIndex].Value.ToString();
                string col12 = StudentGrid[11, StudentGrid.CurrentCell.RowIndex].Value.ToString();
                string col13 = StudentGrid[12, StudentGrid.CurrentCell.RowIndex].Value.ToString();

                string insert_sql = "INSERT INTO StudentInformation([School ID],first_Name,last_Name,[Course Taken],[Class 1 Midterm],[Class 2 Midterm],[Class 3 Midterm],[Class 4 Midterm],[Class 1 Finals],[Class 2 Finals],[Class 3 Finals],[Class 4 Finals], GPA)VALUES('" + col1 + "','" + col2 + "','"+ col3 + "','" + col4 + "','" + col5 + "','" + col6 + "','" + col7 + "','" + col8 + "','" + col9 + "','" + col10 + "','" + col11 + "','" + col12 + "','" + col13 + "')";

                if (this.grabCom(insert_sql))
                {
                    MessageBox.Show("Insert Success");
                }
                else
                {
                    MessageBox.Show("Insert Failed");
                }
                //this.grabCom(insert_sql);
            }
            catch(Exception ex)
            {
                
            }
            //Create a Visble Grid for All student information
            StudentGrid.Visible = true;
            defaultGridView.Visible = false;
        }

        private void addStudentData_Click(object sender, EventArgs e)
        {
            //Create a Visble Grid for All student information
            StudentGrid.Visible = true;
            defaultGridView.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //Create a Visble Grid for All student information
            StudentGrid.Visible = true;
            defaultGridView.Visible = false;
        }

        private void defaultGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Create a Visble Grid for All student information
            StudentGrid.Visible = true;
            defaultGridView.Visible = false;
        }
    }
}
