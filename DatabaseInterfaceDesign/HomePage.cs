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
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {

            LoginPageForm login = new LoginPageForm();
            this.Hide();
            login.Show();

            
        }
    }
}
