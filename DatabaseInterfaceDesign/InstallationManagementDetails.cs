using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseInterfaceDesign
{
    public partial class InstManDetForm : Form
    {
        public InstManDetForm()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FOM4FAB\MSSQLSERVER01;Initial Catalog=PollyPipe_DB;Integrated Security=True");

        public void LoadTableFun()
        {
            string sql = "select * from Installation_Management_Detail";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Installation_Management_Detail");
            InstMangDetGridview .DataSource = ds.Tables["Installation_Management_Detail"].DefaultView;
        }

        public void LoadforeignkeyInComboBox(String sql, ComboBox comboBox, String Staff_IDColumn)
        {

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = Staff_IDColumn;
            comboBox.ValueMember = Staff_IDColumn;
            comboBox.DataSource = dt;

        }

        public void Loadforeignkey(ComboBox comboBox)
        {
            String sql = "select * from Staff_Type";
            LoadforeignkeyInComboBox(sql, comboBox, "Staff_ID");
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

        private void InstMenuBtn_Click(object sender, EventArgs e)
        {
            InstMenuForm installMenu = new InstMenuForm();
            this.Hide();
            installMenu.Show();
        }

        private void InstManDetForm_Load(object sender, EventArgs e)
        {
            Loadforeignkey(StaffIDComboBox);
            LoadTableFun();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                String Installation_ID = installIDTextBox.Text;
                String Staff_ID = StaffIDComboBox.Text;
                String Number_of_Staff = numofstaffTextBox.Text;

                String InstallationManagement_insert = "INSERT INTO Installation_Management_Detail VALUES('" + Installation_ID + "','" + Staff_ID + "','"+ Number_of_Staff + "')";

                SqlCommand cmd = new SqlCommand(InstallationManagement_insert, con);

                con.Open();

                int rowsCount = cmd.ExecuteNonQuery();

                if (rowsCount > 0)
                {
                    MessageBox.Show("Data Insert Successfuy", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                LoadTableFun();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String Installation_ID = installIDTextBox.Text;

                String installationManagement_Delete = "DELETE From Installation_Management_Detail WHERE Installation_ID = '" + Installation_ID + "'";

                SqlCommand cmd = new SqlCommand(installationManagement_Delete, con);

                con.Open();

                int rowsCount = cmd.ExecuteNonQuery();

                if (rowsCount > 0)
                {
                    MessageBox.Show("Data Delete Successfuy", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                LoadTableFun();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }

            finally
            {
                con.Close();
            }
        }
    }
}
