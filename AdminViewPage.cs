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
    public partial class AdminViewForm : Form
    {
        public AdminViewForm()
        {
            InitializeComponent();
        }

        private void studentInformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentInfoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentInfoDataSet.StudentInformation' table. You can move, or remove it, as needed.
            this.studentInformationTableAdapter.Fill(this.studentInfoDataSet.StudentInformation);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void school_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.studentInformationBindingSource.AddNew();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentInfoDataSet);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.studentInformationBindingSource.RemoveCurrent();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            
            using (LoginForm login = new LoginForm())  // Initialize LoginForm to a value
            {
                this.Hide(); // First need to hide main page
                login.ShowDialog(); //Enable you to go back to Login Page Form
                //this.Close();
                //login.Dispose();
                //Application.Exit();
                //this.Close(); // Make sure to close out this MainPage Window
            }
        }

        private void gPATextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
