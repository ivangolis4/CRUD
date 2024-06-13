namespace CRUD
{
    partial class addform
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
            label1 = new Label();
            TBNAME = new TextBox();
            TBQUANTITY = new TextBox();
            tbprice = new TextBox();
            BTNADD = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 27);
            label1.TabIndex = 0;
            label1.Text = "ADD PRODUCT";
            // 
            // TBNAME
            // 
            TBNAME.Location = new Point(36, 65);
            TBNAME.Name = "TBNAME";
            TBNAME.PlaceholderText = "PRODUCT NAME";
            TBNAME.Size = new Size(185, 23);
            TBNAME.TabIndex = 1;
            // 
            // TBQUANTITY
            // 
            TBQUANTITY.Location = new Point(36, 109);
            TBQUANTITY.Name = "TBQUANTITY";
            TBQUANTITY.PlaceholderText = "QUANTITY";
            TBQUANTITY.Size = new Size(185, 23);
            TBQUANTITY.TabIndex = 2;
            // 
            // tbprice
            // 
            tbprice.Location = new Point(36, 152);
            tbprice.Name = "tbprice";
            tbprice.PlaceholderText = "PRICE";
            tbprice.Size = new Size(185, 23);
            tbprice.TabIndex = 3;
            // 
            // BTNADD
            // 
            BTNADD.Location = new Point(86, 208);
            BTNADD.Name = "BTNADD";
            BTNADD.Size = new Size(75, 23);
            BTNADD.TabIndex = 4;
            BTNADD.Text = "ADD";
            BTNADD.UseVisualStyleBackColor = true;
            BTNADD.Click += BTNADD_Click;
            // 
            // addform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 256);
            Controls.Add(BTNADD);
            Controls.Add(tbprice);
            Controls.Add(TBQUANTITY);
            Controls.Add(TBNAME);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addform";
            Text = "addform";
            Load += addform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBNAME;
        private TextBox TBQUANTITY;
        private TextBox tbprice;
        private Button BTNADD;
    }
}