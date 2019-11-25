using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackboard_Application
{
    public partial class AdminPageForm : Form
    {
        public AdminPageForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blackboardDatabase.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.blackboardDatabase.Users);
            // TODO: This line of code loads data into the 'blackboardDatabase.GradeBook' table. You can move, or remove it, as needed.
            this.gradeBookTableAdapter.Fill(this.blackboardDatabase.GradeBook);
            // TODO: This line of code loads data into the 'blackboardDatabase.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.blackboardDatabase.Course);
            // TODO: This line of code loads data into the 'blackboardDatabase.StudentInformation' table. You can move, or remove it, as needed.
            this.studentInformationTableAdapter.Fill(this.blackboardDatabase.StudentInformation);

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

        private void button2_Click(object sender, EventArgs e)
        {
            //Create a Visble Grid for All student information
            viewStudentGrid.Visible = true;
            defaultGridView.Visible = false;
        }

        private void addStudentData_Click(object sender, EventArgs e)
        {
            //Create a Visble Grid for All student information
            viewStudentGrid.Visible = true;
            defaultGridView.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //Create a Visble Grid for All student information
            viewStudentGrid.Visible = true;
            defaultGridView.Visible = false;
        }

        private void defaultGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Create a Visble Grid for All student information
            viewStudentGrid.Visible = true;
            defaultGridView.Visible = false;
        }
    }
}
