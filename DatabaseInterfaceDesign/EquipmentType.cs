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
    public partial class EqTypeForm : Form
    {
        public EqTypeForm()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FOM4FAB\MSSQLSERVER01;Initial Catalog=PollyPipe_DB;Integrated Security=True");

        public void LoadTableFun()
        {
            string sql = "select * from Equipment_Type";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Equipment_Type");
            EqTypeGridView.DataSource = ds.Tables["Equipment_Type"].DefaultView;
        }

        private void EqMenuBtn_Click(object sender, EventArgs e)
        {
            EquipmentMenuForm equipmentMenu = new EquipmentMenuForm();
            this.Hide();
            equipmentMenu.Show();
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

        private void EqTypeForm_Load(object sender, EventArgs e)
        {
            LoadTableFun();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                String Equipment_Type_ID = EqTypeIDTextBox.Text;
                String Type = EqTypeTextBox.Text;

                String EqType_insert = "INSERT INTO Equipment_Type VALUES('" + Equipment_Type_ID + "','" + Type + "')";

                SqlCommand cmd = new SqlCommand(EqType_insert, con);

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
                String Equipment_Type_ID = EqTypeIDTextBox.Text;
                String Type = EqTypeTextBox.Text;

                String equipmentType_update = "UPDATE Equipment_Type SET Type = '" + Type + "' WHERE Equipment_Type_ID = '" + Equipment_Type_ID + "'";

                SqlCommand cmd = new SqlCommand(equipmentType_update, con);

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
                String Equipment_Type_ID = EqTypeIDTextBox.Text;

                String equipmentRequirement_Delete = "DELETE From Equipment_Type WHERE Equipment_Type_ID = '" + Equipment_Type_ID + "'";

                SqlCommand cmd = new SqlCommand(equipmentRequirement_Delete, con);

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
