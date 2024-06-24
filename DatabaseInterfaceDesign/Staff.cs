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
    public partial class StaffForm : Form
    {
       
        public StaffForm()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FOM4FAB\MSSQLSERVER01;Initial Catalog=PollyPipe_DB;Integrated Security=True");

        public void LoadTableFun()
        {
            string sql = "select * from Staff";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Staff");
            StaffGridView.DataSource = ds.Tables["Staff"].DefaultView;
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

        private void StaffMenuBtn_Click(object sender, EventArgs e)
        {
            StaffMenuForm staffMenu = new StaffMenuForm();
            this.Hide();
            staffMenu.Show();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            Loadforeignkey(StaffIDComboBox);
            LoadTableFun();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String Staff_Number = StaffNumTextBox.Text;
                String Name = NameTextBox.Text;
                String Staff_ID = StaffIDComboBox.Text;

                String Staff_insert = "INSERT INTO Staff VALUES('" + Staff_Number + "','" + Name + "','" + Staff_ID + "')";

                SqlCommand cmd = new SqlCommand(Staff_insert, con);

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
                String Staff_Number = StaffNumTextBox.Text;
                String Name = NameTextBox.Text;
                String Staff_ID = StaffIDComboBox.Text;

                String staff_update = "UPDATE Staff SET  Staff_Number = '" + Staff_Number + "', Name = '" + Name + "', Staff_ID = '" + Staff_ID + "' WHERE Staff_Number = '" + Staff_Number + "'";

                SqlCommand cmd = new SqlCommand(staff_update, con);

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
                if (MessageBox.Show("Do you want to delete the data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Staff_Number = StaffNumTextBox.Text;

                    String staff_Delete = "DELETE From Staff WHERE Staff_Number = '" + Staff_Number + "'";

                    SqlCommand cmd = new SqlCommand(staff_Delete, con);

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
                else
                {
                    MessageBox.Show("Data Delete Selection is cancelled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
