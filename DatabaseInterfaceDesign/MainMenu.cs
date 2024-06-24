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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void CustomerMenuBtn_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            this.Hide();
            customer.Show();
        }

        private void InstMenuBtn_Click(object sender, EventArgs e)
        {
            InstMenuForm installMenu = new InstMenuForm();
            this.Hide();
            installMenu.Show();
        }

        private void EqMenuBtn_Click(object sender, EventArgs e)
        {
            EquipmentMenuForm equipmentMenu = new EquipmentMenuForm();
            this.Hide();
            equipmentMenu.Show();
        }

        private void StaffMenuBtn_Click(object sender, EventArgs e)
        {
            StaffMenuForm staffMenu = new StaffMenuForm();
            this.Hide();
            staffMenu.Show();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to go to  login page?", "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginPageForm login = new LoginPageForm();
                this.Hide();
                login.Show();
            }
            else
            {

            }
            
        }
    }
}
