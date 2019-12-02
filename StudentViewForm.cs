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
            /*school_IDTextBox;
            first_NameTextBox;
            last_NameTextBox;
            course_TakenTextBox;
            class_1_MidtermTextBox;
            class_2_MidtermTextBox;
            class_3_MidtermTextBox;
            class_4_MidtermTextBox;
            class_1_FinalsTextBox;
            class_2_FinalsTextBox;
            class_3_FinalsTextBox;
            class_4_FinalsTextBox;
            gPATextBox;*/
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
            afterloginbox.Text = LoginForm.passingText;
        }

        private void first_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            /*school_IDTextBox;
        first_NameTextBox;
        last_NameTextBox;
        course_TakenTextBox;
        class_1_MidtermTextBox;
        class_2_MidtermTextBox;
        class_3_MidtermTextBox;
        class_4_MidtermTextBox;
        class_1_FinalsTextBox;
        class_2_FinalsTextBox;
        class_3_FinalsTextBox;
        class_4_FinalsTextBox;
        gPATextBox;*/
        }
    }
}
