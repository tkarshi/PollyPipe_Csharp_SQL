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
    public partial class InstMenuForm : Form
    {
        public InstMenuForm()
        {
            InitializeComponent();
        }

        private void InstManDetBtn_Click(object sender, EventArgs e)
        {
            InstManDetForm instMD = new InstManDetForm();
            this.Hide();
            instMD.Show();
        }

        private void InstallationBtn_Click(object sender, EventArgs e)
        {
            InstallationForm instForm = new InstallationForm();
            this.Hide();
            instForm.Show();
        }

        private void InstDetMainMenuBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to go to Main Menu?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MainMenuForm mainMenu = new MainMenuForm();
                this.Hide();
                mainMenu.Show();
            }
            else
            {

            }
        
        }

    }
}
