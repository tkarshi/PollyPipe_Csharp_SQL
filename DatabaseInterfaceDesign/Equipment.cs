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
    public partial class EquipmentForm : Form
    {
        public EquipmentForm()
        {
            InitializeComponent();
            
        }

        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FOM4FAB\MSSQLSERVER01;Initial Catalog=PollyPipe_DB;Integrated Security=True");

        public void LoadTableFun()
        {
            string sql = "select * from Equipment";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Equipment");
            EqGridView.DataSource = ds.Tables["Equipment"].DefaultView;
        }

        public void InstallationView()
        {
            string sql = "select * from Installation";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Installation");
            InstallationGridview.DataSource = ds.Tables["Installation"].DefaultView;
        }

        public void LoadforeignkeyInComboBox(String sql, ComboBox comboBox, String Equipment_Type_IDColumn)
        {

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = Equipment_Type_IDColumn ;
            comboBox.ValueMember = Equipment_Type_IDColumn;
            comboBox.DataSource = dt;

        }

        public void Loadforeignkey(ComboBox comboBox)
        {
            String sql = "select * from Equipment_Type";
            LoadforeignkeyInComboBox(sql, comboBox, "Equipment_Type_ID");
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

        private void EquipmentForm_Load(object sender, EventArgs e)
        {
            Loadforeignkey(EqTyIDComboBox);
            LoadTableFun();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {


                String Equipment_ID = EqIDTextBox.Text;
                String Equipment_Name = EqNameTextBox.Text; 
                

                String equipment_insert = "INSERT INTO Equipment VALUES('" + Equipment_ID + "','" + Equipment_Name  + "')";

                SqlCommand cmd = new SqlCommand(equipment_insert, con);

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

                String Equipment_ID = EqIDTextBox.Text;
                String Equipment_Name = EqNameTextBox.Text;
                String Equipment_Type_ID = EqTyIDComboBox.Text;

                String equipment_update = "UPDATE Equipment SET Equipment_Name = '" + Equipment_Name + "', Equipment_Type_ID = '" + Equipment_Type_ID + "' WHERE Equipment_ID = '" + Equipment_ID  + "'";

                SqlCommand cmd = new SqlCommand(equipment_update , con);

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
                string Equipment_ID = EqIDTextBox.Text;

                String equipment_Delete = "DELETE From Customer WHERE Equipment_ID = '" + Equipment_ID + "'";

                SqlCommand cmd = new SqlCommand(equipment_Delete, con);

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

        private void EqIDSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string equipmentId = SearchTextBox.Text;
                String equipment_Search = "Select*from Equipment where Equipment_ID = '" + equipmentId + "'";

                SqlCommand cmd = new SqlCommand(equipment_Search, con);
                con.Open();

                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    EqIDTextBox.Text = r[0].ToString();
                    EqNameTextBox.Text = r[1].ToString();

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

        private void viewInstBtn_Click(object sender, EventArgs e)
        {
            InstallationView();
        }

        private void ADDEqReqBtn_Click(object sender, EventArgs e)
        {
            EqRequirementForm eqRequirementForm = new EqRequirementForm();
            eqRequirementForm.Show();
        }
    }
}
