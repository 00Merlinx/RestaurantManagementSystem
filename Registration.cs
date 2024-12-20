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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            passtxtbox.PasswordChar = '*';
            conpasstxtbox.PasswordChar = '*';
        }


        private void showpass_CheckedChanged(object sender, EventArgs e)
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
        private void showpass2_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (showpass2.Checked)
                {
                    conpasstxtbox.PasswordChar = '\0';
                }
                else
                {
                    conpasstxtbox.PasswordChar = '*';
                }
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            {
                string name = nametxtbox.Text.Trim();
                string username = usertxtbox.Text.Trim();
                string password = passtxtbox.Text.Trim();
                string confirmPassword = conpasstxtbox.Text.Trim();

                // 1. Field Validation
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) ||
                    string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("All fields are required. Please fill in every field.", "Validation Error");
                    return;
                }

                // 2. Password Validation
                if (password.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Password Error");
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please check and try again.", "Password Mismatch");
                    return;
                }

                // 3. Check for Duplicate Username
                if (connectDB.IsUsernameTaken(username))
                {
                    MessageBox.Show("This username is already taken. Please choose another one.", "Duplicate Username");
                    return;
                }

                // 4. Register User
                try
                {
                    if (connectDB.RegisterUser(name, username, password, confirmPassword))
                    {
                        MessageBox.Show("Registration successful! You can now log in.", "Success");
                        Login loginForm = new Login();
                        loginForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again later.", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                }
            }
        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void nametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usertxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void conpasstxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
