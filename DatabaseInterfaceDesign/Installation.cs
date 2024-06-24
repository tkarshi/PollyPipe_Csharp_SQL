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
    public partial class InstallationForm : Form
    {
        //InstallationStaffRequirement installStaff = new InstallationStaffRequirement();


          public InstallationForm()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FOM4FAB\MSSQLSERVER01;Initial Catalog=PollyPipe_DB;Integrated Security=True");

        public void LoadTableFun()
        { 
            string sql = "select * from Installation";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Installation");
            InstGridview.DataSource = ds.Tables["Installation"].DefaultView;
        }

        public void Loadfk_CustomerIDInComboBox(String sql, ComboBox comboBox, String Customer_IDColumn)
        {
            
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);    
            comboBox.DisplayMember =Customer_IDColumn;
            comboBox.ValueMember = Customer_IDColumn;
            comboBox.DataSource = dt;
            
        }

        public void LoadInstallationTypeNameInComboBox(String sql, ComboBox comboBox, String Installation_TypeColumnName, String Installation_Type_IDColumn)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);        
            comboBox.DisplayMember = Installation_TypeColumnName;
            comboBox.ValueMember = Installation_Type_IDColumn;
            comboBox.DataSource = dt;


        }

        public void LoadforeignkeyCustomer(ComboBox comboBox)
        {
            String sql = "select * from Customer";

            Loadfk_CustomerIDInComboBox (sql, comboBox, "Customer_ID");

        }

        public void LoadforeignkeyInstallationType(ComboBox comboBox)
        {
            String sql = "select * from Installation_Type";
            LoadInstallationTypeNameInComboBox(sql, comboBox, "Installation_Type", "Installation_Type_ID");
        }

        private void InstMenuBtn_Click(object sender, EventArgs e)
        {
            InstMenuForm installMenu = new InstMenuForm();
            this.Hide();
            installMenu.Show();
        }

        private void InstMainMenuBtn_Click(object sender, EventArgs e)
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
        private void InstallationForm_Load(object sender, EventArgs e)
        {
            LoadforeignkeyCustomer(CustomerIDComboBox);
            LoadforeignkeyInstallationType(installTyComboBox);
            LoadTableFun();
        }

        private void InstStaffRequireBtn_Click(object sender, EventArgs e)
        {
            InstallationStaffRequirement staffRequirement = new InstallationStaffRequirement();
            //this.Hide();
            staffRequirement.Show();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String Inatallation_ID = installationIDTextBox.Text;
                String Installation_Name = installationNameTextBox.Text;
                String Installation_Address = installAddressTextBox.Text;
                String Period_of_Staff_assign_From = periodofstaffasignTextBox.Text;
                String Customer_ID = CustomerIDComboBox.Text;
                String Installation_Type_ID = installTyComboBox.Text;
                String Period_of_Staff_assign_To = null;

                String Installation_insert = "INSERT INTO Installation VALUES('" + Inatallation_ID + "','" + Installation_Type_ID + "','" + Installation_Name + "','" + Installation_Address + "','" + Period_of_Staff_assign_From + "','" + Period_of_Staff_assign_To + "','" + Customer_ID + "')";

                SqlCommand cmd = new SqlCommand(Installation_insert, con);

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
                String Inatallation_ID = installationIDTextBox.Text;
                String Installation_Name = installationNameTextBox.Text;
                String Installation_Address = installAddressTextBox.Text;
                String Period_of_Staff_assign = periodofstaffasignTextBox.Text;
                String Customer_ID = CustomerIDComboBox.Text;
                String Installation_Type = installTyComboBox.Text;

                String installation_update = "UPDATE Installation SET Installation_Name = '" + Installation_Name + "', Installation_Name = '" + Installation_Name + "', Installation_Address = '" + Installation_Address + "' , Period_of_Staff_assign = '" + Period_of_Staff_assign + "' , Customer_ID = '" + Customer_ID + "' , Installation_Type = '" + Installation_Type + " WHERE Installation_ID = '" + Inatallation_ID + "'";

                SqlCommand cmd = new SqlCommand(installation_update, con);

                con.Open();

                cmd.ExecuteNonQuery();

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
                    string Installation_ID = installationIDTextBox.Text;

                    String installation_Delete = "DELETE From Installation WHERE Installation_ID = '" + Installation_ID + "'";

                    SqlCommand cmd = new SqlCommand(installation_Delete, con);

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
