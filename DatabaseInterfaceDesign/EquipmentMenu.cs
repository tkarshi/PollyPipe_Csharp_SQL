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
    public partial class EquipmentMenuForm : Form
    {
        public EquipmentMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
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

        private void EqBtn_Click(object sender, EventArgs e)
        {
            EquipmentForm eqForm = new EquipmentForm();
            this.Hide();
            eqForm.Show();
        }

        private void EqTypeBtn_Click(object sender, EventArgs e)
        {
            EqTypeForm eqTypeForm = new EqTypeForm();
            this.Hide();
            eqTypeForm.Show();
        }

        private void EqRequirementBtn_Click(object sender, EventArgs e)
        {
            EqRequirementForm eqRequirement = new EqRequirementForm();
            this.Hide();
            eqRequirement.Show();
        }
    }
}
