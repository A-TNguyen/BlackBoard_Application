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
            this.studentInformationTableAdapter.Fill(this.studentInfoDataSet.StudentInformation);

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // First need to hide main page
            LoginForm login = new LoginForm(); // Initialize LoginForm to a value
            login.ShowDialog(); //Enable you to go back to Login Page Form
            Application.Exit(); //Close out the form
        }
    }
}
