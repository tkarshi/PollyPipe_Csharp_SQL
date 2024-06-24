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
    public partial class StaffMenuForm : Form
    {
        public StaffMenuForm()
        {
            InitializeComponent();
        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {
            StaffForm stForm = new StaffForm();
            this.Hide();
            stForm.Show();
        }

        private void StaffTypeBtn_Click(object sender, EventArgs e)
        {
            StaffTypeForm stTyForm = new StaffTypeForm();
            this.Hide();
            stTyForm.Show();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            this.Hide();
            mainMenu.Show();
        }
    }
    
}
