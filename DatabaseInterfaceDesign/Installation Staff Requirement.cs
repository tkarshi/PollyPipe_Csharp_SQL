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
    public partial class InstallationStaffRequirement : Form
    {     
        public InstallationStaffRequirement()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FOM4FAB\MSSQLSERVER01;Initial Catalog=PollyPipe_DB;Integrated Security=True");

        public void LoadTableFun()
        {
            string sql = "select * from Installation_Staff_Requirement";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Installation_Staff_Requirement");
            StaffGridView.DataSource = ds.Tables["Installation_Staff_Requirement"].DefaultView;
        }

        public void LoadStaffNumberInComboBox(String sql, ComboBox comboBox, String Staff_NumberColumn)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = Staff_NumberColumn;
            comboBox.ValueMember = Staff_NumberColumn;
            comboBox.DataSource = dt;

        }
        public void Loadforeignkey(ComboBox comboBox)
        {
            String sql = "select * from Installation_Staff_Requirement";
            LoadStaffNumberInComboBox(sql, comboBox, "Staff_Number");
            
        }

        private void InstallationStaffRequirement_Load(object sender, EventArgs e)
        {

            LoadTableFun();
            Loadforeignkey(StaffNumComboBox);

        }

        private void InstallationMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm main = new MainMenuForm();
            this.Hide();
            main.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String Inatallation_ID = installIDTextBox.Text;
                String Staff_Number = StaffNumComboBox.Text;

                String InstallReq_insert = "INSERT INTO Installation_Staff_Requirement VALUES('" + Inatallation_ID + "','" + Staff_Number + "')";

                SqlCommand cmd = new SqlCommand(InstallReq_insert, con);

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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String Inatallation_ID = installIDTextBox.Text;
                String Staff_Number = StaffNumComboBox.Text;

                String installationRequirement_update = "UPDATE Installation_Staff_Requirement SET Staff_Number = '" + Staff_Number + "' WHERE Installation_ID  = '" + Inatallation_ID + "'";

                SqlCommand cmd = new SqlCommand(installationRequirement_update, con);

                con.Open();

                int rowsCount = cmd.ExecuteNonQuery();

                if (rowsCount > 0)
                {
                    MessageBox.Show("Data Updated Successfuy", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                String Inatallation_ID = installIDTextBox.Text;

                String installationRequirement_Delete = "DELETE From Installation_Staff_Requirement WHERE Installation_ID = '" + Inatallation_ID + "'";

                SqlCommand cmd = new SqlCommand(installationRequirement_Delete, con);

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
