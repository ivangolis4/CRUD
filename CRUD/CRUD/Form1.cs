using System.Data;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {

        private Form currentForm = null;
        private string connectionString = "Data Source=DESKTOP-4MHNQL2\\SQLEXPRESS;Initial Catalog=PRODUCT_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";

        private int selectedProductQuantity = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string query = "SELECT * FROM products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        public void ReloadDataAndHidePanel()
        {
            LoadData();
            panelContainer.Visible = false;
        }

        private void LoadForm(Form form)
        {
            if (currentForm != null && currentForm.GetType() == form.GetType())
            {
                this.panelContainer.Controls.Remove(currentForm);
                currentForm = null;
                this.panelContainer.Visible = false;
            }
            else
            {
                if (this.panelContainer.Controls.Count > 0)
                    this.panelContainer.Controls.RemoveAt(0);

                currentForm = form;
                currentForm.TopLevel = false;
                currentForm.Dock = DockStyle.Fill;
                this.panelContainer.Controls.Add(currentForm);
                this.panelContainer.Tag = currentForm;
                currentForm.Show();
                this.panelContainer.Visible = true;
            }
        }

        private void DeleteSelectedRow()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }


            int rowIndex = dataGridView1.SelectedRows[0].Index;
            string productId = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

            string deleteQuery = "DELETE FROM products WHERE Product_ID = @ProductId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductId", productId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Selected row deleted successfully.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("No rows deleted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            this.panelContainer.Visible = false;
            
            LoadData();

            lbquantity.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new addform(this));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new updateform(this));
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                string column3Value = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();

                int column3IntValue;
                if (!int.TryParse(column3Value, out column3IntValue))
                {
                    MessageBox.Show("Invalid quantity value in the selected row.");
                    return;
                }

                int currentQuantity = int.Parse(lbquantity.Text);
                lbquantity.Text = (currentQuantity + 1).ToString();

                if (int.Parse(lbquantity.Text) < column3IntValue)
                {
                    btnplus.Enabled = true;
                }
                else
                {
                    btnplus.Enabled = false;
                }

                if (int.Parse(lbquantity.Text) > 0)
                {
                    btnminus.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }


        }

        private void btnminus_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                int currentQuantity = int.Parse(lbquantity.Text);
                lbquantity.Text = (currentQuantity - 1).ToString();

                int rowIndex = dataGridView1.SelectedRows[0].Index;

                string column3Value = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();

                int column3IntValue;
                if (!int.TryParse(column3Value, out column3IntValue))
                {
                    MessageBox.Show("Invalid quantity value in the selected row.");
                    return;
                }

                if (int.Parse(lbquantity.Text) < column3IntValue)
                {
                    btnplus.Enabled = true;
                }
                else
                {
                    btnplus.Enabled = false;
                }

                if (int.Parse(lbquantity.Text) > 0)
                {
                    btnminus.Enabled = true;
                }
                else
                {
                    btnminus.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }

        }

        private void lbquantity_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                string column3Value = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();

                int column3IntValue;
                if (!int.TryParse(column3Value, out column3IntValue))
                {
                    MessageBox.Show("Invalid quantity value in the selected row.");
                    return;
                }

                if (int.Parse(lbquantity.Text) < column3IntValue)
                {
                    btnplus.Enabled = true;
                }
                else
                {
                    btnplus.Enabled = false;
                }

                if (int.Parse(lbquantity.Text) > 0)
                {
                    btnminus.Enabled = true;

                }
                else
                {
                    btnminus.Enabled = false;
                    btnplus.Enabled = true;
                }
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
 
            lbquantity.Text = "0";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                string column3Value = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();

                int column3IntValue;
                if (!int.TryParse(column3Value, out column3IntValue))
                {
                    MessageBox.Show("Invalid quantity value in the selected row.");
                    return;
                }
                if (int.Parse(lbquantity.Text) < column3IntValue)
                {
                    btnplus.Enabled = true;
                }
                else
                {
                    btnplus.Enabled = false;
                }
                if (int.Parse(lbquantity.Text) > 0)
                {
                    btnminus.Enabled = true;
                }
                else
                {
                    btnminus.Enabled = false;
                }
            }
            else
            {
                btnplus.Enabled = false;
                btnminus.Enabled = false;
            }
        }



    }
}
