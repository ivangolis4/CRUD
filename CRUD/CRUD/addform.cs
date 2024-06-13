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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class addform : Form
    {
        Form1 form1;

        public addform(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private string connectionString = "Data Source=DESKTOP-4MHNQL2\\SQLEXPRESS;Initial Catalog=PRODUCT_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
        
        
        
        private void AddProduct(string productName, int productQuantity, decimal productPrice)
        {
         
            string checkQuery = "SELECT COUNT(*) FROM products WHERE Product_Name = @Product_Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@Product_Name", productName);

                try
                {
                    connection.Open();
                    int existingCount = (int)checkCommand.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        MessageBox.Show("Product with the same name already exists. Please enter a different name.");
                    }
                    else
                    {
                   
                        string insertQuery = "INSERT INTO products (Product_Name, Quantity, Price) VALUES (@Product_Name, @Quantity, @Price)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Product_Name", productName);
                            insertCommand.Parameters.AddWithValue("@Quantity", productQuantity);
                            insertCommand.Parameters.AddWithValue("@Price", productPrice);
                            insertCommand.ExecuteNonQuery();

                            MessageBox.Show("Product added successfully.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            AddProduct(TBNAME.Text, int.Parse(TBQUANTITY.Text), int.Parse(tbprice.Text));
            form1.ReloadDataAndHidePanel();

        }

        private void addform_Load(object sender, EventArgs e)
        {
            var label1 = new Label()
            {
                Height = 1,
                Dock = DockStyle.Bottom,
                BackColor = Color.Black
            };

            var label2 = new Label()
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

            TBNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TBNAME.Controls.Add(label2);

            TBQUANTITY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TBQUANTITY.Controls.Add(label3);
        }
    }
}
