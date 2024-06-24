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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FOM4FAB\MSSQLSERVER01;Initial Catalog=PollyPipe_DB;Integrated Security=True");

        public void LoadTableFun()
        {
            string sql = "select * from Customer";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customer");
            CusGridview.DataSource = ds.Tables["Customer"].DefaultView;
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
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadTableFun();   
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (( NameTextBox.Text == "" || ConNumTextBox.Text == ""))
                {
                    MessageBox.Show("Data not valid, Please enter valid Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    String Customer_ID = CusIDTextBox.Text;
                    String Name = NameTextBox.Text;
                    int Contact_Number = int.Parse(ConNumTextBox.Text);

                    String basic_details = "INSERT INTO Customer VALUES('"  + Name + "', '" + Contact_Number + "')";

                    SqlCommand cmd = new SqlCommand(customer_insert, con);

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
           
            }
            catch(Exception ex)
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
                    String Customer_ID = CusIDTextBox.Text;
                    String Name = NameTextBox.Text;
                    int Contact_Number = int.Parse(ConNumTextBox.Text);                  

                    String customer_update = "UPDATE Customer SET  Name = '" + Name + "', Contact_Number = " + Contact_Number + " WHERE Customer_ID = '" + Customer_ID + "'";

                    SqlCommand cmd = new SqlCommand(customer_update, con);
                   
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
                    string Customer_ID = CusIDTextBox.Text;

                    String customer_Delete = "DELETE From Customer WHERE Customer_ID = '" + Customer_ID + "'";

                    SqlCommand cmd = new SqlCommand(customer_Delete, con);

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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string customerId = CustomerIDSearchTextBox.Text; 
                String customer_Search = "Select*from Customer where Customer_ID = '" + customerId + "'";

                SqlCommand cmd = new SqlCommand(customer_Search, con);
                con.Open();

                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    CusIDTextBox.Text = r[0].ToString();
                    NameTextBox .Text = r[1].ToString();
                    ConNumTextBox.Text = r[2].ToString();
                    

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

        private void ClearTextBoxBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to clear the text in text boxes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                CusIDTextBox.Clear();
                NameTextBox.Clear();
                ConNumTextBox.Clear();

            }
            else
            {

            }
        }
    }
 
        
 }

