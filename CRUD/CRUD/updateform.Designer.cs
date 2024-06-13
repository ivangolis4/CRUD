namespace CRUD
{
    partial class updateform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTNUPDATE = new Button();
            tbprice = new TextBox();
            TBQUANTITY = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // BTNUPDATE
            // 
            BTNUPDATE.Location = new Point(87, 216);
            BTNUPDATE.Name = "BTNUPDATE";
            BTNUPDATE.Size = new Size(75, 23);
            BTNUPDATE.TabIndex = 9;
            BTNUPDATE.Text = "UPDATE";
            BTNUPDATE.UseVisualStyleBackColor = true;
            BTNUPDATE.Click += BTNADD_Click;
            // 
            // tbprice
            // 
            tbprice.Location = new Point(37, 160);
            tbprice.Name = "tbprice";
            tbprice.PlaceholderText = "PRICE";
            tbprice.Size = new Size(185, 23);
            tbprice.TabIndex = 8;
            tbprice.TextChanged += tbprice_TextChanged;
            // 
            // TBQUANTITY
            // 
            TBQUANTITY.Location = new Point(37, 117);
            TBQUANTITY.Name = "TBQUANTITY";
            TBQUANTITY.PlaceholderText = "QUANTITY";
            TBQUANTITY.Size = new Size(185, 23);
            TBQUANTITY.TabIndex = 7;
            TBQUANTITY.TextChanged += TBQUANTITY_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 18);
            label1.Name = "label1";
            label1.Size = new Size(181, 27);
            label1.TabIndex = 5;
            label1.Text = "UPDATE PRODUCT";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(37, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // updateform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 256);
            Controls.Add(comboBox1);
            Controls.Add(BTNUPDATE);
            Controls.Add(tbprice);
            Controls.Add(TBQUANTITY);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "updateform";
            Text = "updateform";
            Load += updateform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNUPDATE;
        private TextBox tbprice;
        private TextBox TBQUANTITY;
        private Label label1;
        private ComboBox comboBox1;
    }
}