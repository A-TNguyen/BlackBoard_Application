using Blackboard_Application.Connection;
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
    public partial class LoginForm : Form
    {
        //Create a string the name passingUsername 
        public static string passingUsername;
        public LoginForm()
        {
            
            InitializeComponent();
            
        }

        private void Login_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_page_Load(object sender, EventArgs e)
        {
            loginInput.Select();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //We set the username input you type and set it to passingUsername
            passingUsername = loginInput.Text;
            //If statement where String Input Cannot be null or empty
            if(!string.IsNullOrEmpty(loginInput.Text) &&
            !string.IsNullOrEmpty(passwordInput.Text))
            {
                var mySql = string.Empty;

                
                mySql += "SELECT * FROM Users "; //To Select all attributes from the User Table
                mySql += "WHERE username ='"+ loginInput.Text +"' "; //Where username is the input
                //mySQL += "WHERE username = 'tester' ";
                mySql += "AND password = '"+ passwordInput.Text +"'"; //AND the password Input 
                                                                      //mySQL += "AND password = '1'";

                //Using helps dispose of null connection
                var userData = SQLServerConnection.ExecuteSql(mySql);
                if (userData.Rows.Count > 0)
                {
                        
                        if (loginInput.Text == "admin") //Execute AdminViewPage.cs
                        {
                            loginInput.Clear();
                            passwordInput.Clear();
                            var addPage = new AdminViewForm();// Initialize LoginForm to a value
                            this.Hide(); // First need to hide main page
                            addPage.ShowDialog(); //Enable you to go back to Login Page Form
                            this.loginInput.Select();
                            
                        }
                        else
                        {
                            loginInput.Clear();
                            passwordInput.Clear();
                            var studentPage = new StudentViewForm(); // Initialize LoginForm to a value
                            this.Hide(); // First need to hide main page
                            studentPage.ShowDialog(); //Enable you to go back to Login Page Form
                            this.loginInput.Select();


                        }
                }
                else
                {
                        MessageBox.Show("Wrong Username or Password", "Please Try Again",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        loginInput.Focus();
                        loginInput.SelectAll();
                }
                

            }

            else
            {
                MessageBox.Show("Please enter a username and password.","Try Again", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                loginInput.Select();

            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentInfoDataSet);

        }
    }
}
