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
    public partial class StaffTypeForm : Form
    {
        public StaffTypeForm()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FOM4FAB\MSSQLSERVER01;Initial Catalog=PollyPipe_DB;Integrated Security=True");

        public void LoadTableFun()
        {
            string sql = "select * from Staff_Type";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Staff_Type");
            StaffTyGridView.DataSource = ds.Tables["Staff_Type"].DefaultView;
        }

        private void StaffMenuBtn_Click(object sender, EventArgs e)
        {
            StaffMenuForm staffMenu = new StaffMenuForm();
            this.Hide();
            staffMenu.Show();
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
        private void StaffTypeForm_Load(object sender, EventArgs e)
        {
            LoadTableFun();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String Staff_ID = StaffIDTextBox.Text;
                String Type = StTyTextBox.Text;

                String Staff_insert = "INSERT INTO Staff_Type VALUES('" + Staff_ID + "','" + Type + "')";

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
                String Staff_ID = StaffIDTextBox.Text;
                String Type = StTyTextBox.Text;

                String staff_update = "UPDATE Staff_Type SET  Type = '" + Type  + "' WHERE Staff_ID = '" + Staff_ID + "'";

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
                    String Staff_ID = StaffIDTextBox.Text;

                    String staffType_Delete = "DELETE From Staff_Type WHERE Staff_ID = '" + Staff_ID + "'";

                    SqlCommand cmd = new SqlCommand(staffType_Delete, con);

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
