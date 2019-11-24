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
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
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

        }
    }
}
