using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class updateform : Form
    {
        Form1 fORM1;
        public updateform(Form1 fORM1)
        {
            InitializeComponent();
            this.fORM1 = fORM1;
        }

        private string connectionString = "Data Source=DESKTOP-4MHNQL2\\SQLEXPRESS;Initial Catalog=PRODUCT_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";


        private void updateform_Load(object sender, EventArgs e)
        {
            LoadProductNames();
            InitializeTextBoxBorders();
        }

        private void LoadProductNames()
        {
            string query = "SELECT Product_Name FROM products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Product_Name"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void InitializeTextBoxBorders()
        {
            var label1 = new Label()
            {
                Height = 1,
                Dock = DockStyle.Bottom,
                BackColor = Color.Black
            };

            var label3 = new Label()
            {
                Height = 1,
                Dock = DockStyle.Bottom,
                BackColor = Color.Black
            };

            tbprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbprice.Controls.Add(label1);

            TBQUANTITY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TBQUANTITY.Controls.Add(label3);
        }

        private void UpdateProduct(string productName, int newQuantity, decimal newPrice)
        {
            string query = "UPDATE products SET Quantity = @Quantity, Price = @Price WHERE Product_Name = @Product_Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Product_Name", productName);
                        command.Parameters.AddWithValue("@Quantity", newQuantity);
                        command.Parameters.AddWithValue("@Price", newPrice);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Product updated successfully.");
                        fORM1.ReloadDataAndHidePanel();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TBQUANTITY_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            string selectedProductName = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedProductName))
            {
                MessageBox.Show("Please select a product from the list.");
                return;
            }

            if (!string.IsNullOrEmpty(TBQUANTITY.Text) || !string.IsNullOrEmpty(tbprice.Text))
            {
                // Parse quantity and price values
                int newQuantity = 0;
                decimal newPrice = 0;

                if (!string.IsNullOrEmpty(TBQUANTITY.Text) && int.TryParse(TBQUANTITY.Text, out int parsedQuantity))
                {
                    newQuantity = parsedQuantity;
                }

                if (!string.IsNullOrEmpty(tbprice.Text) && decimal.TryParse(tbprice.Text, out decimal parsedPrice))
                {
                    newPrice = parsedPrice;
                }

                // Update product in the database
                UpdateProduct(selectedProductName, newQuantity, newPrice);
            }
            else
            {
                MessageBox.Show("Please enter a new quantity or price to update.");
            }

            

            }
    }
}
