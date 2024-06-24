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
    public partial class EqRequirementForm : Form
    {
        public EqRequirementForm()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FOM4FAB\MSSQLSERVER01;Initial Catalog=PollyPipe_DB;Integrated Security=True");

        public void LoadTableFun()
        {
            string sql = "select * from Equipment_Requirement";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Equipment_Requirement");
            EqRequireDataGridview .DataSource = ds.Tables["Equipment_Requirement"].DefaultView;
        }

        public void LoadforeignkeyInComboBox(String sql, ComboBox comboBox, String Equipment_IDColumn)
        {

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = Equipment_IDColumn;
            comboBox.ValueMember = Equipment_IDColumn;
            comboBox.DataSource = dt;

        }

        public void Loadforeignkey(ComboBox comboBox)
        {
            String sql = "select * from Equipment";
            LoadforeignkeyInComboBox(sql, comboBox, "Equipment_ID");
        }

        private void EqMenuBtn_Click(object sender, EventArgs e)
        {         
            this.Hide();
        }

        private void EqRequirementForm_Load(object sender, EventArgs e)
        {
            Loadforeignkey(EqIDComboBox);
            LoadTableFun();
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            try
            {

                String Installation_ID = InstIDTextBox.Text;
                String Equipment_ID = EqIDComboBox.Text;
                String Equiipment_Quantity = eqQuantityTextBox.Text;

                String equipmentRequirement_insert = "INSERT INTO Equipment_Requirement VALUES('" + Installation_ID + "','" + Equipment_ID + "','" + Equiipment_Quantity + "')";

                SqlCommand cmd = new SqlCommand(equipmentRequirement_insert, con);

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
            //try
            //{

            //    String Installation_ID = InstIDTextBox.Text;
            //    String Equipment_ID = EqIDComboBox.Text;
            //    String Equipment_Quantity = eqQuantityTextBox.Text;

            //    //String equipmentRequirement_update = "UPDATE Equipment_Requirement SET Equipment_Quantity = '" + Equipment_Quantity + "' WHERE Installation_ID = '" + Installation_ID +  "'"  "&& "  " Equipment_ID = '" + Equipment_ID + "'";

            //    //SqlCommand cmd = new SqlCommand(equipmentRequirement_update, con);

            //    con.Open();

            //    int rowsCount = cmd.ExecuteNonQuery();

            //    if (rowsCount > 0)
            //    {
            //        MessageBox.Show("Data Updated Successfuy", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Data not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }

            //    LoadTableFun();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error : " + ex);
            //}
            //finally
            //{
            //    con.Close();
            //}
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String Installation_ID = InstIDTextBox.Text;
                String Equipment_ID = EqIDComboBox.Text;

                String equipmentrRequirement_Delete = "DELETE From Customer WHERE Equipment_ID = '" + Equipment_ID + "' && " + " Installation_ID = '" + Equipment_ID + "'";

                SqlCommand cmd = new SqlCommand(equipmentrRequirement_Delete, con);

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
