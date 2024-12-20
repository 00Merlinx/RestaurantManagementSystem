using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            passtxtbox.PasswordChar = '*';
        }

        private void usertxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (showpass.Checked)
                {
                    passtxtbox.PasswordChar = '\0';
                }
                else
                {
                    passtxtbox.PasswordChar = '*';
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            {
                // Trim spaces and check for empty fields
                string username = usertxtbox.Text.Trim();
                string password = passtxtbox.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }

                try
                {
                    if (connectDB.IsValidUser(username, password))
                    {
                        this.Hide();
                        MainActivity mainAct = new MainActivity();
                        mainAct.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while logging in: {ex.Message}");
                }
            }
        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {
            {
                Registration reg = new Registration();
                reg.Show();
                this.Hide();
            }
        }
    }
}
