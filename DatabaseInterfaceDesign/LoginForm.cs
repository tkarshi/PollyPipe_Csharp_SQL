using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseInterfaceDesign
{
    public partial class LoginPageForm : Form
    {
        public LoginPageForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String username = UsernameTextBox.Text;
            String password = PasswordTextBox.Text;

            if (username == "admin@PollyPipe" && password == "PP0456")
            {
                if (MessageBox.Show("Successfully Login, Welcome to Polly Pipe", "Welcome", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    MainMenuForm mainMenu = new MainMenuForm();
                    this.Hide();
                    mainMenu.Show();

                }
                else
                {
                    LoginPageForm loginForm = new LoginPageForm();
                    this.Hide();
                    loginForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Login Not Success, Check your username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HomePageForm homepage = new HomePageForm();
                this.Hide();
                homepage.Show();
            }
            else
            {

            }
        }
    }
}
